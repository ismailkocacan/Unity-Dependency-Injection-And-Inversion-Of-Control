using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using UnitySample;


namespace UnityWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        UnityContainer um = ContainerManager.getContainer();

        public Form1()
        {
            InitializeComponent();

            // sınıfların meta bilgilerini container'a ekleyen methodu çağırıyoruz.
            Initialization.registerObjects();
        }


        public void stokKartiNesnesiOlustur()
        {
            if (!um.IsRegistered<IStockCard>())
                throw new Exception("stok kartı register edilmemiş.");

            /* 
               bir tane stok kartı nesnesi oluştuyoruz.
               farkındaysanız nesne oluşturmak için new operatörü filan kullanmadık.
               inversion of controlün anlamıda zaten budur.yani nesne oluşturmak bunu takibini yapmak bizim işimiz değil.
            */
            var stockCard = um.Resolve<IStockCard>();
            // veya aşağıdaki şekilde de containerdan objecte erişmek mümkün.
            //var stockCard = this.getDIContainer().Resolve<IStockCard>();
            stockCard.stockCode = "ST0001";
            stockCard.stockName = "Buzdolabı";
            stockCard.insertionTime = DateTime.Now;
            stockCard.unitPrice = 2500;
            stockCard.amount = 60;

            // farkındaysanız üst satırlada stockCard.stockCategory propertisini de set etmedik :)
            stockCard.stockCategory.categoryName = "Beyaz Eşya";
            stockCard.stockCategory.id = 1;
            stockCard.stockCategory.insertionTime = DateTime.Now;



            // stok kartının propertylerini okuyoruz.
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("stockCard.stockCode {0} : ", stockCard.stockCode));
            sb.Append(string.Format("stockCard.stockName {0} : ", stockCard.stockName));
            sb.Append(string.Format("stockCard.insertionTime {0} : ", stockCard.insertionTime));
            sb.Append(string.Format("stockCard.amount {0} : ", stockCard.amount));

            sb.Append(string.Format("stockCard.stockCategory.categoryName {0} : ", stockCard.stockCategory.categoryName));
            sb.Append(string.Format("stockCard.stockCategory.id {0} : ", stockCard.stockCategory.id));
            sb.Append(string.Format("stockCard.stockCategory.insertionTime {0} : ", stockCard.stockCategory.insertionTime));
            tBoxStockProp.Text = sb.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            stokKartiNesnesiOlustur();
        }
    }
}
