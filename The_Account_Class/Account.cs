namespace The_Account_Class;

internal class Account {
    private readonly String _id;
    private readonly String _name;
    private int _balance = 0;
    public String Id => _id;

    public String Name => _name;

    public int Balance => _balance;

    public Account(string id, string name) {
        this._id = id;
        this._name = name;
    }
    public Account(string id, string name, int balance) {
        this._id = id;
        this._name = name;
        this._balance = balance;
    }
    public int Credit(int amount) {
        return _balance + amount;
    }

    public int Debit(int amount) {
        if (amount <= Balance) {
            _balance -= amount;
        } else {
            Console.WriteLine("Amount exceeded balance");
        }
        return Balance;
    }

    public int TransferTo(Account another, int amount) {
        if (amount <= Balance) {
            Debit(amount);
            another.Credit(amount);
        } else {
            Console.WriteLine("Amount exceeded balance");
        }
        return Balance;
    }
    public override String ToString() {
        return $"Account[id={Id},name={Name},balance={Balance}]";
    }
}