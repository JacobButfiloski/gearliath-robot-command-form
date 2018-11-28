using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace GearliathRobotCommandForm
{
    public partial class Form1 : Form
    {
        private List<Command> commandList = new List<Command> { };
        public Command[] commandArr;
        protected string[] validCommands = new string[]
        {
            "Move",
            "TurnRight",
            "TurnLeft",
            "ToggleServo"
        };
        public bool editing = false;
        public int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            commandList = JsonConvert.DeserializeObject<List<Command>>(File.ReadAllText(@"C:/CommandData.json"));
            populateHierarchy();
            foreach(Command c in commandArr)
            {
                Console.WriteLine(c.commandType + " cmd");
            }
        }

        private void listToArr()
        {
            commandArr = commandList.ToArray();
            for(int i = 0; i < commandArr.Length; i++)
            {
                commandArr[i].index = i;
            }
        }

        private void inputCmdButton_Click(object sender, EventArgs e)
        {
            populateHierarchy();
            if (!editing)
            {
                Command temp = new Command(inputBox.Text);
                bool valid = false;
                foreach (string s in validCommands)
                {
                    if (s == temp.commandType)
                    {
                        valid = true;
                    }
                }

                if(valid)
                {
                    commandList.Add(new Command(inputBox.Text));
                }
                           
            } else
            {
                Command temp = new Command(inputBox.Text);
                bool valid = false;
                foreach(string s in validCommands)
                {
                    if(s == temp.commandType)
                    {
                        valid = true;
                    }
                }
                if(valid)
                {
                    commandList[selectedIndex] = temp;
                    labelArr[selectedIndex].Refresh();
                    labelArr[selectedIndex].Text = commandList[selectedIndex].commandType + " " + commandList[selectedIndex].ticks;
                    labelArr[selectedIndex].Refresh();               
                }
                
                editing = false;
                
                selectedIndex = -1;
            }
            inputBox.Text = "";
            populateHierarchy();
        }

        protected int _labelX = 4;
        protected int _labelYMod = 25;
        Label[] labelArr = new Label[] { };
        private void populateHierarchy()
        {
            listToArr();
            foreach(Label l in labelArr)
            {
                l.Dispose();
            }
            labelArr = new Label[commandArr.Length];
            int foo = -1;
            foreach(Command c in commandArr)
            {
                foo++;
                Label t = new Label();
                t.Text = c.commandType + " " + c.ticks;
                t.Location = new Point(_labelX, _labelYMod * foo);
                t.Click += new EventHandler(onLabelPress);
                t.Name = "lbl" + foo;
                labelArr[foo] = t;
                panel1.Controls.Add(labelArr[foo]);
            }
        }

        private void onLabelPress(object sender, EventArgs e)
        {
            populateHierarchy();
            Label t = (Label)sender;
            int index = 0;
            string temp = "";
            foreach(char c in t.Name)
            {
                if(c != 'l' && c != 'b')
                {
                    temp += c;
                }
            }
            index = int.Parse(temp);
            selectedIndex = index;
            editing = true;
            inputBox.Text = commandArr[index].commandType + " " + commandArr[index].ticks;
            //Index Box Setting
            indexTextBox.Text = commandArr[index].index.ToString();
            //
            foreach (Label l in labelArr)
            {
                Color refer;
                if (selectedIndex != 0)
                {
                    refer = labelArr[0].ForeColor;
                } else if(labelArr.Length > 1)
                {
                    refer = labelArr[1].ForeColor;
                }
                if(labelArr.Length > 1)
                {
                    refer = new Color();
                    l.ForeColor = refer;
                }
                
            }
            labelArr[selectedIndex].ForeColor = Color.DarkGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void removeCmdButton_Click(object sender, EventArgs e)
        {
            if(selectedIndex != -1)
            {
                populateHierarchy();
                commandList.Remove(commandList[selectedIndex]);
                selectedIndex = -1;
                populateHierarchy();
                inputBox.Text = "";
                editing = false;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var HelpForm = new HelpForm();
            HelpForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateHierarchy();
            File.WriteAllText(@"C:\CommandData.json", JsonConvert.SerializeObject(commandArr));
        }

        private void indexTextBox_TextChanged(object sender, EventArgs e) //Index Box Changed
        {
            /*int index = selectedIndex;
            TextBox l = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(l.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                l.Text = l.Text.Remove(l.Text.Length - 1);
            }
            commandList[index].index = int.Parse(l.Text);
            populateHierarchy();*/
        }
    }

    public class Command
    {
        public string commandType { get; set; }
        public int ticks { get; set; }
        public int index { get; set; }

        public Command()
        {

        }

        public Command(string command)
        {
            string t = "";
            bool tb = false;
            foreach(char c in command)
            {
                if(c != ' ' && tb == false)
                {
                    t += c;
                } else if(c == ' ' && tb == false)
                {
                    this.commandType = t;
                    t = "";
                    tb = true;
                }
                if(tb)
                {
                    t += c;
                }
            }
            int toss;
            bool numeric = int.TryParse(t, out toss);
            if(numeric)
            {
                this.ticks = int.Parse(t);
            }
        }
    }
}
