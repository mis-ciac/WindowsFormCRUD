using WinFormsCRUD.Script.Component.Data;

namespace WinFormsCRUD;

public partial class Form1 : Form
{
    public event EventHandler<Employee?>? OnSaveButtonClicked;
    public event EventHandler<Employee?>? OnUpdateButtonClicked;
    public event EventHandler<Employee?>? OnDeleteButtonClicked;

    private int UserID;
    public Form1() => InitializeComponent();

    public void Initialize(IReadOnlyCollection<Employee> employees)
    {
        if (employees == null) return;

        dgvEmployeeList.DataSource = employees;
    }

    private Employee GetEmployeeFromInput()
    {
        return new Employee
        (
            UserID: 0,
            FirstName: txtFirstName.Text,
            LastName: txtLastName.Text
        );
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var isNull = string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text);
        var employee = GetEmployeeFromInput() ?? null;

        if (isNull)
        {
            MessageBox.Show("Please fill in all fields.");
            return;
        }

        OnSaveButtonClicked?.Invoke(sender, employee);

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var isNull = string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text);
        var employee = GetEmployeeFromInput() ?? null;
        if (isNull)
        {
            MessageBox.Show("Please fill in all fields.");
            return;
        }

        OnUpdateButtonClicked?.Invoke(sender, employee);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var isNull = string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text);
        var employee = GetEmployeeFromInput() ?? null;
        if (isNull)
        {
            MessageBox.Show("Please fill in all fields.");
            return;
        }

        OnDeleteButtonClicked?.Invoke(sender, employee);
    }

    private void dgvEmployeeList_DoubleClick(object sender, EventArgs e)
    {
        if (dgvEmployeeList.CurrentRow != null)
        {
            var row = dgvEmployeeList.CurrentRow;

            UserID = row.Cells["UserID"].Value != null ? Convert.ToInt32(row.Cells["UserID"].Value) : 0;
            txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
            txtLastName.Text = row.Cells["LastName"].Value.ToString();
        }
    }

    
}
