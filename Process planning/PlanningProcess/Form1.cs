using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        private List<Process> _listOfProcess = new List<Process>();
        private List<Process> _sortedList = new List<Process>();
        public int IdCounter = 0; // Счетчик id
        public int CentralProcessorCounter = 0; // Счетчик нагрузки процессора
        public int AllocatedMemoryCounter = 0; // Счетки выделенной памяти
        
        private void DeleteElementsFromTextBox() // Удаление элемента из списка
        {
            while(true)
            {
                if(ProcessList.Items.Count > 0) 
                {
                    Process itemNow = (Process) ProcessList.Items[0]; // Получение текущей записи по ID 
                    Thread.Sleep(itemNow.TimeToExecute); // Ожидание во время выполнения задачи
                    CentralProcessorCounter -= itemNow.HighlightingCentralProcessor;
                    CP_Counter_label.Text = CentralProcessorCounter.ToString();
                    AllocatedMemoryCounter -= itemNow.AllocatedMemory;
                    Memory_Counter_label.Text = AllocatedMemoryCounter.ToString();
                    Invoke(new MethodInvoker(() => ProcessList.Items.RemoveAt(0))); // Удаление из списка выполненной задачи
                }
            } 
        }

        private void DateTimeNowChanger() // Обновление текущего системного времени
        {
            while (true)
            {
                CurrentTime_label.Text = DateTime.Now.ToString();
            }  
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Поток удаляющий элементы из списка
            Thread deleteElementsListBox = new Thread(DeleteElementsFromTextBox)
            {
                IsBackground = true
            };
            deleteElementsListBox.Start();
            
            
            // Поток показ системной даты 
            Thread updateDateTineNow = new Thread(DateTimeNowChanger)
            {
                IsBackground = true
            };
            updateDateTineNow.Start();
        }
        
        private void AddProcessLow_Click(object sender, EventArgs e) // Добавление маленького процесса для FCFS
        {
            Process lowProcess = new Process(IdCounter, 10, 20, 2000); // Конструктор процесса
            _process.ProcessFifo.Enqueue(lowProcess); // Добавление в очередь
            ProcessList.Items.Add(_process.ProcessFifo.Dequeue()); // Добавить в список на форме
            IdCounter++; // Увеличение ID для следующего процесса
            CentralProcessorCounter += lowProcess.HighlightingCentralProcessor; // Добавление к счетчику процессора
            AllocatedMemoryCounter += lowProcess.AllocatedMemory; // Добавление к счетчику памяти
            CP_Counter_label.Text = CentralProcessorCounter.ToString(); // Запись значения счетчика процессора в label
            Memory_Counter_label.Text = AllocatedMemoryCounter.ToString(); // Запись значения счетчика памяти в label
        }
        

        private void AddProcessMiddle_Click(object sender, EventArgs e) // Добавление процесса побольше для FCFS
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
        
        private void AddNewCustomProcess_button_Click(object sender, EventArgs e) // Добавление кастомного процесса для FCFS
        {
            if(CPCustomProcess_textBox.Text != string.Empty && MemoryCustomProcess_textBox.Text != string.Empty)
            {
                Process customProcess = new Process(IdCounter, Convert.ToInt32(CPCustomProcess_textBox.Text),
                    Convert.ToInt32(MemoryCustomProcess_textBox.Text), 
                    Convert.ToInt32(CPCustomProcess_textBox.Text) * Convert.ToInt32(MemoryCustomProcess_textBox.Text) * 10);
                _process.ProcessFifo.Enqueue(customProcess);
                ProcessList.Items.Add(_process.ProcessFifo.Dequeue());
                IdCounter++;
                CentralProcessorCounter += customProcess.HighlightingCentralProcessor;
                AllocatedMemoryCounter += customProcess.AllocatedMemory;
                CP_Counter_label.Text = CentralProcessorCounter.ToString();
                Memory_Counter_label.Text = AllocatedMemoryCounter.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Отобразить 1 группу
        {
            FCFS_groupBox.Visible = true;
            RR_groupBox.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Отобразить 2 группу
        {
            FCFS_groupBox.Visible = false;
            RR_groupBox.Visible = true;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void SecondProcess_Low_button_Click(object sender, EventArgs e)
        {
            Process secondProcessLow = new Process(IdCounter, 15, 25, 5000);
            _listOfProcess.Add(secondProcessLow);
            _sortedList = _listOfProcess.OrderBy(o=>o.TimeToExecute).ToList();
            
        }

        private void SecondProcess_Middle_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}