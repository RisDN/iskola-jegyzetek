internal class Stadium {

    private string city;
    private string name1;
    private string name2;
    private int size;
    public Stadium(string line) {

        string[] splitted = line.Split(";");
        this.city = splitted[0];
        this.name1 = splitted[1];
        this.name2 = splitted[2];
        this.size = int.Parse(splitted[3]);

    }


    public string getCity() {
        return this.city;
    }
    public string getName1() {
        return this.name1;
    }

    public string getName2() {
        return this.name2;
    }

    public int getSize() {
        return this.size;
    }
 
}