using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        QueueFifo _process = new QueueFifo(); // Очередь для FIFO
        public int IdCounter = 0; // Счетчик id
        public int CentralProcessorCounter = 0; // Счетчик нагрузки процессора
        public int AllocatedMemoryCounter = 0; // Счетки выделенной памяти
        
        
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Поток удаляющий элементы из списка
            new Thread(() =>
            {
                while(true)
                {
                    if(ProcessList.Items.Count > 0) 
                    {
                        Process itemNow = (Process) ProcessList.Items[0]; 
                        Thread.Sleep(itemNow.TimeToExecute);
                        label1.Text = itemNow.TimeToExecute.ToString();
                        CentralProcessorCounter -= itemNow.HighlightingCentralProcessor;
                        CP_Counter_label.Text = CentralProcessorCounter.ToString();
                        AllocatedMemoryCounter -= itemNow.AllocatedMemory;
                        Memory_Counter_label.Text = AllocatedMemoryCounter.ToString();
                        Invoke(new MethodInvoker(() => ProcessList.Items.RemoveAt(0)));
                    }
                } 
            }).Start(); 
        }
        
        private void AddProcessLow_Click(object sender, EventArgs e)
        {
            Process lowProcess = new Process(IdCounter, 10, 20, 2000);
            _process.ProcessFifo.Enqueue(lowProcess);
            ProcessList.Items.Add(_process.ProcessFifo.Dequeue());
            IdCounter++;
            CentralProcessorCounter += lowProcess.HighlightingCentralProcessor;
            AllocatedMemoryCounter += lowProcess.AllocatedMemory;
            CP_Counter_label.Text = CentralProcessorCounter.ToString();
            Memory_Counter_label.Text = AllocatedMemoryCounter.ToString();
        }

        private void ProcessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddProcessMiddle_Click(object sender, EventArgs e)
        {
            Process middleProcess = new Process(IdCounter, 15, 25, 5000);
            _process.ProcessFifo.Enqueue(middleProcess);
            ProcessList.Items.Add(_process.ProcessFifo.Dequeue());
            IdCounter++;
            CentralProcessorCounter += middleProcess.HighlightingCentralProcessor;
            AllocatedMemoryCounter += middleProcess.AllocatedMemory;
            CP_Counter_label.Text = CentralProcessorCounter.ToString();
            Memory_Counter_label.Text = AllocatedMemoryCounter.ToString();
        }

        private void CentralProcess_Click(object sender, EventArgs e)
        {
            
        }

        private void Memory_Counter_label_Click(object sender, EventArgs e)
        {
            
        }
    }
}