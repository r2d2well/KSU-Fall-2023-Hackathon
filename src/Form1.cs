using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KSU_Fall_2023_Hackathon
{
    public partial class Form1 : Form
    {
        static List<SpecialLabel> list = new List<SpecialLabel>();
        public static string name;
        int timePassed;
        static Label timeLabel = new Label();
        static SpecialLabel brushTeethLabel;

        public Form1()
        {
            SetUpForm();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddSpecialLabel(string name)
        {
            SpecialLabel sLabel = new SpecialLabel(name);
            sLabel.AutoSize = true;
            sLabel.Name = name;
            sLabel.Size = new Size(264, 46);
            sLabel.TabIndex = 0;
            sLabel.Text = name;
            sLabel.MouseClick += LabelOnMouseClick;

            list.Add((SpecialLabel) sLabel);
            Controls.Add((SpecialLabel) sLabel);
        }

        private void SetUpForm()
        {
            using (StreamReader reader = new StreamReader("Task.txt")) //Uses StreamReader to iterate though the file
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != "")
                    {
                       AddSpecialLabel(line);
                    }
                }
            }
        }

        private void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter("Task.txt"))
            {
                foreach (SpecialLabel x in list)
                {
                    writer.WriteLine(x.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectTaskForm SelectTaskForm = new SelectTaskForm();
            SelectTaskForm.ShowDialog();
            if (name == "")
            {
                return;
            }
            AddSpecialLabel(name);
        }

        private void RemoveLabel(int index)
        {
            Controls.Remove(list[index]);
            list.RemoveAt(index);
            for (int x = index; x < list.Count;  x++)
            {
                list[x].id--;
                SpecialLabel.count--;
                Point point = list[x].Location;
                point.Offset(0, -100);
                list[x].Location = point;
            }
        }

        protected void LabelOnMouseClick(object sender, MouseEventArgs e)
        {
            SpecialLabel label = (SpecialLabel)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (label.Font.Strikeout)
                {
                    label.Font = new Font("Segoe", 24);
                }
                else
                {
                    if (label.Text == "Brush Teeth")
                    {
                        timePassed = 0;
                        brushTeethLabel = (SpecialLabel) sender;
                        CreateTimeLabel((SpecialLabel)sender);
                        System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
                        MyTimer.Interval = (1000); // 1 sec
                        MyTimer.Tick += new EventHandler (MyTimer_Tick);
                        MyTimer.Start();
                    }
                    else
                    {
                        label.Font = new Font("Segoe", 24, FontStyle.Strikeout);
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                RemoveLabel(label.id);
            }
        }

        private void saveFile(object sender, FormClosedEventArgs e)
        {
            UpdateFile();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            updateTime((System.Windows.Forms.Timer) sender);
        }

        private void CreateTimeLabel(SpecialLabel label)
        {
            timeLabel = new Label();
            timeLabel.Font = new Font("Segoe", 24);
            timeLabel.AutoSize = true;
            Point point = label.Location;
            point.Offset(300, 0);
            timeLabel.Location = point;
            Controls.Add(timeLabel);
        }

        private void updateTime(System.Windows.Forms.Timer timer)
        {
            if (timePassed == 120)
            {
                timePassed = 0;
                brushTeethLabel.Font = new Font("Segoe", 24, FontStyle.Strikeout);
                timer.Stop();
                Controls.Remove(timeLabel);
            }
            int timeLeft = 120 - timePassed;
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            timeLabel.Text = minutes + ":" + seconds.ToString("D2");
            timePassed++;
        }
    }
}