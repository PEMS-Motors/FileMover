using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileMover.Constants.FileLocations;
using FileMover.Constants.FileLocations;
using FileMover.Modules;
using System;
using System.IO;

namespace FileMover
{
    public partial class RunManualForm : Form
    {
        //Read the live full file name
        public string LiveFileName = new Modules.FileName().FullOrderName;
        public string LivePrimeName = new Modules.FileName().FullPrimeName;
        public string whMI = new Constants.WarehouseLocations.WhLocations().MI;
        public string whIL = new Constants.WarehouseLocations.WhLocations().IL;
        public string LiveOrderNumber = new Modules.FileName().FullOrderName.Split().Last();

        public RunManualForm()
        {
            InitializeComponent();
        }

        private void Name_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for MI PickTickets
                if (LiveFileName.Contains(whMI) || (LiveOrderNumber.Contains(LiveFileName)))
                {
                    File.Move(Constants.FileLocations.Folders.HotFolder, Constants.FileLocations.Folders.path01A);
                }else
                {
                    Console.WriteLine("The process failed: {0}");
                }

                //Check for IL PickTickets
                if (LiveFileName.Contains(whIL) || (LiveOrderNumber.Contains(LiveFileName)))
                {
                    File.Move(Constants.FileLocations.Folders.HotFolder, Constants.FileLocations.Folders.path02A);
                }else
                {
                    Console.WriteLine("The process failed: {0}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("The process failed: {0}", error.ToString());
            }

        }
    }
}
