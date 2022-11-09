using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanningProcess
{
    public class Process
    {
        public int Id { get; set; } // айди
        public int HighlightingCentralProcessor { get; set; } // нагрузка на процессор
        public int AllocatedMemory { get; set; } // Выделение памяти
        public DateTime AppearanceTime { get; set; } // Время появления
        
        public int TimeToExecute { get; set; } // Время на выполнение задачи

        public Process(int id, int highlightingCentralProcessor, int allocatedMemory, int timeToExecute)
        {
            Id = id;
            HighlightingCentralProcessor = highlightingCentralProcessor;
            AllocatedMemory = allocatedMemory;
            AppearanceTime = DateTime.Now;
            TimeToExecute = timeToExecute;
        }

        public override string ToString()
        {
            return $" ID: {Id} ЦП: {HighlightingCentralProcessor} Память: {AllocatedMemory} Время появления: {AppearanceTime}";
        }
    }
    
    public partial class Form1 : Form
    {
        QueueFifo process = new QueueFifo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void AddProcessLow_Click(object sender, EventArgs e)
        {
            process.ProcessFifo.Enqueue(new Process(1, 10, 20, 5));
            ProcessList.Items.Add(process.ProcessFifo.Dequeue());
        }

        private void ProcessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddProcessMiddle_Click(object sender, EventArgs e)
        {
            process.ProcessFifo.Enqueue(new Process(2, 15, 25, 10));
            ProcessList.Items.Add(process.ProcessFifo.Dequeue());
        }
    }
}