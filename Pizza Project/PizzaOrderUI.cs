using System.Diagnostics.CodeAnalysis;

namespace Pizza_Project
{
    public partial class PizzaOrderUI : Form
    {
        public PizzaOrderUI()
        {
            InitializeComponent();
        }

        /*
         * In WinForms, every control is part of a hierarchy.
         *   Controls can be placed inside other controls (such as Panel, GroupBox, etc.).
         *   For example, if you have a Form with a Panel, and inside that panel,
         *   you have buttons, textboxes, etc.,
         *   all of those controls are child controls of the Panel.
         *   
         *   Recursion with parentControl:
         *   
         *   Instead of calling the method recursively for the entire form (Form),
         *   we pass the parent control (starting from this, which is the form) down the call stack.
         *   This allows the method to focus on the current control's children
         */
        private void ToggleControlsExceptOne(Control parentControl, Control? controlToKeepEnabled, bool isEnabled)
        {
            foreach (Control Ctrl in parentControl.Controls)
            {
                Ctrl.Enabled = isEnabled;
                if (Ctrl.HasChildren == true && Ctrl != controlToKeepEnabled)
                    ToggleControlsExceptOne(Ctrl, null, isEnabled);
            }
            if (controlToKeepEnabled != null)
                controlToKeepEnabled.Enabled = true;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Confirm Order", "Confirmation",
                                                   MessageBoxButtons.YesNoCancel,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button3);
            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);

                /*
                 * In WinForms, Control is the base class for most UI elements like buttons,
                 *   textboxes, labels, and even the Form itself.
                 *   This means that Form inherits from Control, so a Form is also considered a Control.
                 *   

                 System.Object
                  ??? System.Windows.Forms.Control
                           ??? System.Windows.Forms.Form
                           ??? System.Windows.Forms.Button
                           ??? System.Windows.Forms.TextBox
                           ??? (Other UI elements)

                 * Control is the base class for all Windows Forms controls.
                 * Form is a subclass of Control and therefore inherits all the properties and methods of Control.
                 * In fact, the Form class is itself a type of Control.
                 */
                ToggleControlsExceptOne(this, btnResetForm, false);
            }
            if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("Order Canceled; System will stop", "Cancelling", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                ToggleControlsExceptOne(this, btnResetForm, false);

            }
        }

        private void DisableCheckedCtrls(Control Ctrl)
        {
            if (Ctrl is CheckBox chk && chk.Checked)
                chk.Checked = false;
            else if (Ctrl is RadioButton rdo && rdo.Checked)
                rdo.Checked = false;
        }

        private void uncheckAllChecked(Control ParentCtrl)
        {
            foreach (Control Ctrl in ParentCtrl.Controls)
            {
                DisableCheckedCtrls(Ctrl);
                if (Ctrl.HasChildren == true)
                    uncheckAllChecked(Ctrl);
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can Order Again", "Notification", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            ToggleControlsExceptOne(this, null, true);
            uncheckAllChecked(this);
            updateToppings();
            updateCrustType();
            updateSize();
        }

        /*
        private float getSelectedSizePrice()
        {
            if (rdoLargeSize.Checked == true)
                return (Convert.ToSingle(rdoLargeSize.Tag));
            else if (rdoMediumSize.Checked == true)
                return (Convert.ToSingle(rdoMediumSize.Tag));
            else if (rdoLargeSize.Checked == true)
                return (Convert.ToSingle(rdoLargeSize.Tag));
            else
                return ((float) 0.0);
        }

        private float getToppingsPrice()
        {
            float ToppingTotalPrice = 0;

            foreach (Control Ctrl in gbToppings.Controls)
            {
                if (Ctrl is CheckBox chkedTopping && chkedTopping.Checked)
                    ToppingTotalPrice += Convert.ToSingle(chkedTopping.Tag);
            }
            return (ToppingTotalPrice);
        }

        private float getChosenCrustPrice()
        {
            float CrustPrice = 0;

            foreach(Control Ctrl in gbCrustType.Controls)
            {
                if (Ctrl is RadioButton rdoCrustType && rdoCrustType.Checked)
                    CrustPrice = Convert.ToSingle(rdoCrustType.Tag);
            }
            return (CrustPrice);
        }
        */


        /*
         * The `is` keyword in C# is used to check if an object is of a certain type.
         * When combined with the && operator and a variable declaration,
         * it allows for type checking and variable assignment in a single step.
         * This syntax is commonly called "type pattern matching".
         * 
         * 1. The is keyword checks whether the object ctrl is of type RadioButton.
         * 2. If it is, the control is cast to a RadioButton type,
         *      and it is assigned to the variable rdo.
         *      So now you can use rdo as a RadioButton object in the rest of the condition.
         * 3. If ctrl is not a RadioButton, this part fails, and the rest of the condition is not evaluated.
         */
        private float GetSelectedPrice(Control Container)
        {
            float TotalPrice = 0;

            foreach (Control Ctrl in Container.Controls)
            {
                if (Ctrl is RadioButton rdo && rdo.Checked)
                    TotalPrice += Convert.ToSingle(rdo.Tag);
                if (Ctrl is CheckBox chk && chk.Checked)
                    TotalPrice += Convert.ToSingle(chk.Tag);
            }
            return (TotalPrice);
        }


        private float getSelectedSizePrice()
        {
            return (GetSelectedPrice(gbSize));
        }

        private float getToppingsPrice()
        {
            return (GetSelectedPrice(gbToppings));
        }

        private float getChosenCrustPrice()
        {
            return (GetSelectedPrice(gbCrustType));
        }

        private float getTotalPrice()
        {
            return (getSelectedSizePrice() + getToppingsPrice() + getChosenCrustPrice());
        }

        private void updateTotalPrice()
        {
            lblTotalPrice.Text = getTotalPrice().ToString() + "$";
        }


        // Sizes Handling
        private void updateSize()
        {
            bool isSet = false;

            updateTotalPrice();

            foreach (Control Ctrl in gbSize.Controls)
            {
                if (Ctrl is RadioButton rdo && rdo.Checked)
                {
                    lblSize.Text = rdo.Text;
                    isSet = true;
                    return;
                }
            }
            if (isSet == false)
                lblSize.Text = "";
        }

        private void rdoSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rdoMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rdoLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }


        // Crust Type Handling
        private void updateCrustType()
        {
            bool isSet = false;

            updateTotalPrice();

            foreach (Control Ctrl in gbCrustType.Controls)
            {
                if (Ctrl is RadioButton rdo && rdo.Checked)
                {
                    lblCrstType.Text = rdo.Text + " Crust";
                    isSet = true;
                    return;
                }
            }
            if (isSet == false)
                lblCrstType.Text = "";
        }

        private void rdoThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrustType();
        }

        private void rdoThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrustType();
        }


        // Toppings Handling

        private void updateToppings()
        {
            updateTotalPrice();

            List<string> selectedToppings = new List<string>();

            foreach (Control Ctrl in gbToppings.Controls)
            {
                if (Ctrl is CheckBox chk && chk.Checked)
                    selectedToppings.Add(chk.Text + Environment.NewLine);
            }

            if (selectedToppings.Count == 0)
            {
                lblToppings.Text = "No Toppings.";
                return;
            }
            else
                lblToppings.Text = string.Join(", ", selectedToppings);
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }


        private void updateWhereToEat()
        {
            foreach (Control Ctrl in gbWhereToEat.Controls)
            {
                if (Ctrl is RadioButton rdo && rdo.Checked)
                {
                    lblWhereEat.Text = rdo.Text;
                    return;
                }
            }
            lblWhereEat.Text = "";
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void rdoEatOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void PizzaOrderUI_Load(object sender, EventArgs e)
        {
            ToggleControlsExceptOne(this, null, true);
            uncheckAllChecked(this);
            updateToppings();
            updateCrustType();
            updateSize(); 
        }
    }
}
