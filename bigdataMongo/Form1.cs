using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigdataMongo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxCreateId.Text.Length == 0 || txtboxCreateName.Text.Length == 0 || txtboxCreateSurname.Text.Length == 0 || txtboxCreateAge.Text.Length == 0 || txtboxCreateLocation.Text.Length == 0)
            {
                MessageBox.Show("Textboxes can't be empty.", "Error");
            }
            else
            {
                MongoClient dbClient = new MongoClient("mongodb+srv://admin:admin@bigdatamongo.ufcdr.mongodb.net/sample_training?retryWrites=true&w=majority");
                var database = dbClient.GetDatabase("sample_training");
                var collection = database.GetCollection<BsonDocument>("user");
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(txtboxCreateId.Text));
                var document = collection.Find(filter).FirstOrDefault();
                if (document != null)
                { 
                    MessageBox.Show("Id was taken.", "Error"); 
                }
                else if(document == null)
                {
                    var db = dbClient.GetDatabase("sample_training");
                    var addDc = new BsonDocument { { "id", int.Parse(txtboxCreateId.Text) },
                                              { "name", txtboxCreateName.Text  },
                                              { "surname", txtboxCreateSurname.Text },
                                              { "age", int.Parse(txtboxCreateAge.Text) },
                                              { "location", txtboxCreateLocation.Text }
                    };
                    var collec = database.GetCollection<BsonDocument>("user");
                    collec.InsertOneAsync(addDc);
                    txtboxCreateId.Text = "";
                    txtboxCreateName.Text = "";
                    txtboxCreateSurname.Text = "";
                    txtboxCreateAge.Text = "";
                    txtboxCreateLocation.Text = "";
                }
            }
        }
        
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            txtboxGet.Text = "";
            MongoClient dbClient = new MongoClient("mongodb+srv://admin:admin@bigdatamongo.ufcdr.mongodb.net/sample_training?retryWrites=true&w=majority");
            var database = dbClient.GetDatabase("sample_training");
            var collection = database.GetCollection<BsonDocument>("user");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument doc in documents)
            {
                txtboxGet.Text += doc.ToString() + Environment.NewLine;
            }
        }   

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtboxGetId.Text.Length == 0)
            {
                MessageBox.Show("Textboxes can't be empty.", "Error");
            }
            else
            {
                txtboxGet.Text = "";
                MongoClient dbClient = new MongoClient("mongodb+srv://admin:admin@bigdatamongo.ufcdr.mongodb.net/sample_training?retryWrites=true&w=majority");
                var database = dbClient.GetDatabase("sample_training");
                var collection = database.GetCollection<BsonDocument>("user");
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(txtboxGetId.Text));
                var document = collection.Find(filter).FirstOrDefault();
                txtboxGet.Text = document.ToString();
                txtboxGetId.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxUpdateId.Text.Length == 0 || txtboxUpdateName.Text.Length == 0 || txtboxUpdateSurname.Text.Length == 0 || txtboxUpdateAge.Text.Length == 0 || txtboxUpdateLocation.Text.Length == 0)
            {
                MessageBox.Show("Textboxes can't be empty.", "Error");
            }
            else
            {
                MongoClient dbClient = new MongoClient("mongodb+srv://admin:admin@bigdatamongo.ufcdr.mongodb.net/sample_training?retryWrites=true&w=majority");
                var database = dbClient.GetDatabase("sample_training");
                var collection = database.GetCollection<BsonDocument>("user");
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(txtboxUpdateId.Text));
                var update = Builders<BsonDocument>.Update.Set("name", txtboxUpdateName.Text).
                                                           Set("surname", txtboxUpdateSurname.Text).
                                                           Set("age", int.Parse(txtboxUpdateAge.Text)).
                                                           Set("location", txtboxUpdateLocation.Text);
                var result = collection.UpdateMany(filter, update);
                txtboxUpdateId.Text = "";
                txtboxUpdateName.Text = "";
                txtboxUpdateSurname.Text = "";
                txtboxUpdateAge.Text = "";
                txtboxUpdateLocation.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtboxDeleteId.Text.Length == 0)
            {
                MessageBox.Show("Textboxes can't be empty.", "Error");
            }
            else
            {
                MongoClient dbClient = new MongoClient("mongodb+srv://admin:admin@bigdatamongo.ufcdr.mongodb.net/sample_training?retryWrites=true&w=majority");
                var database = dbClient.GetDatabase("sample_training");
                var collection = database.GetCollection<BsonDocument>("user");
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(txtboxDeleteId.Text));
                collection.DeleteOne(deleteFilter);
                txtboxDeleteId.Text = "";
            }
        }
    }
}
