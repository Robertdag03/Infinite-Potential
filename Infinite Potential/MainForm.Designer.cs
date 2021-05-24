
namespace Infinite_Potential
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.EatButton = new System.Windows.Forms.Button();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.MoveButton = new System.Windows.Forms.Button();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.ErrorDisplay = new System.Windows.Forms.Label();
            this.OrderFoodButton = new System.Windows.Forms.Button();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EatButton
            // 
            resources.ApplyResources(this.EatButton, "EatButton");
            this.EatButton.Name = "EatButton";
            this.EatButton.UseVisualStyleBackColor = true;
            this.EatButton.Click += new System.EventHandler(this.EatButton_Click);
            // 
            // FoodLabel
            // 
            resources.ApplyResources(this.FoodLabel, "FoodLabel");
            this.FoodLabel.Name = "FoodLabel";
            // 
            // MoveButton
            // 
            resources.ApplyResources(this.MoveButton, "MoveButton");
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // EnergyLabel
            // 
            resources.ApplyResources(this.EnergyLabel, "EnergyLabel");
            this.EnergyLabel.Name = "EnergyLabel";
            // 
            // ErrorDisplay
            // 
            resources.ApplyResources(this.ErrorDisplay, "ErrorDisplay");
            this.ErrorDisplay.Name = "ErrorDisplay";
            // 
            // OrderFoodButton
            // 
            resources.ApplyResources(this.OrderFoodButton, "OrderFoodButton");
            this.OrderFoodButton.Name = "OrderFoodButton";
            this.OrderFoodButton.UseVisualStyleBackColor = true;
            this.OrderFoodButton.Click += new System.EventHandler(this.OrderFoodButton_Click);
            // 
            // MoneyLabel
            // 
            resources.ApplyResources(this.MoneyLabel, "MoneyLabel");
            this.MoneyLabel.Name = "MoneyLabel";
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.OrderFoodButton);
            this.Controls.Add(this.ErrorDisplay);
            this.Controls.Add(this.EnergyLabel);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.FoodLabel);
            this.Controls.Add(this.EatButton);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EatButton;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Label ErrorDisplay;
        private System.Windows.Forms.Button OrderFoodButton;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

