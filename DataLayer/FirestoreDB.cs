using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace DataLayer
{
    public class FirestoreDB
    {
        static readonly string path = "D:\\Plocha\\vsb\\Vis\\Projekt\\Pujcovna dronu\\DataLayer\\pujcovna-dronu-firebase.json";
        private static FirestoreDb instance;
        private static readonly object padlock = new object();

        public FirestoreDB()
        {      
        }

        public static FirestoreDb Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                        instance = FirestoreDb.Create("pujcovna-dronu");
                    }
                    return instance;
                }
            }
        }

        public static async Task<int> maxID(string colectionName)
        {
            int id = 0;
            CollectionReference collection = Instance.Collection(colectionName);
            Query query = collection.OrderByDescending("id").Limit(1);
            QuerySnapshot snapshots = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in snapshots.Documents)
            {
                id = int.Parse(documentSnapshot.Id);
                break;
            }
            return (id + 1);           
        }

        public static async Task<Boolean> Insert(string colectionName, Dictionary<string, object> item)
        {
            string id =  (await maxID(colectionName)).ToString();
            DocumentReference document = Instance.Collection(colectionName).Document(id);
            await document.SetAsync(item);
            return true;
        }

        public static async Task<QuerySnapshot> SelectAll(string colectionName)
        {
            Query query = Instance.Collection(colectionName);
            QuerySnapshot snap = await query.GetSnapshotAsync();
            return snap;
        }

        public static async Task<QuerySnapshot> SelectFilter(string colectionName,string filter , object value)
        {
            CollectionReference collection = Instance.Collection(colectionName);
            Query query = collection.WhereEqualTo(filter, value);
            QuerySnapshot snap = await query.GetSnapshotAsync();
            return snap;
        }

        public static async Task<DocumentSnapshot> Select(string colectionName, int id)
        {
            DocumentReference document = Instance.Collection(colectionName).Document(id.ToString());
            DocumentSnapshot snap = await document.GetSnapshotAsync();
            return snap;
        }

        public static async Task<Boolean> Update(string colectionName, Dictionary<string, object> item, int id)
        {         
            DocumentReference document = Instance.Collection(colectionName).Document(id.ToString());
            DocumentSnapshot snap = await document.GetSnapshotAsync();
            if (snap.Exists)
            {
                await document.UpdateAsync(item);
            }
            return true;
        }

    }
}
