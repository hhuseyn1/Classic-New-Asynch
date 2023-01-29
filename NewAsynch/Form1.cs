using Microsoft.Extensions.Configuration;

namespace NewAsynch
{
    public partial class Form1 : Form
    {
        IConfigurationRoot configurationRoot = null;
        string conStr = string.Empty;
        public Form1()
        {
            InitializeComponent();
            Configure();
        }

        private void Configure()
        {
            string projectPath = Directory.GetCurrentDirectory().Split(@"bin\")[0];

            configurationRoot = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json").Build();



            conStr = configurationRoot.GetConnectionString("ConStr");
        }

        private void Btn_Fill_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }


    }
}