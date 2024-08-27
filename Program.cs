string? choice;
string file = "RelationshipData.txt";

do
{
    //the questions for the menu
    Console.WriteLine("\n1. Display Characters.");
    Console.WriteLine("2. Create new Character.");
    Console.WriteLine("Enter other key to exit.");
    //input the choice
    choice = Console.ReadLine();

    if(choice == "1"){

        //if file exists
        if(File.Exists(file)){

            StreamReader sr = new(file);
            while (!sr.EndOfStream){
                string? line = sr.ReadLine();
                //make array
                string[] arr = String.IsNullOrEmpty(line) ? [] : line.Split('|');
                //display array
                Console.WriteLine("\nId: {0} \nName: {1} \nRelationship to Mario: {2}", arr[0],arr[1],arr[2]);
            }
            sr.Close();
        }
        else{
            Console.WriteLine("File does not exist");
        }
    }
    else if (choice == "2"){
        StreamWriter sw = new(file, true);
        for (int i = 0; i < 1; i++){
            //question
            Console.WriteLine("Add Character (Y/N)?");
            //get response
            string? response = Console.ReadLine()?.ToUpper();
            //if not Y then stop
            if(response != "Y"){break;}
            //Id
            Console.WriteLine("Enter Id number: ");
            string? id = Console.ReadLine();
            //Name
            Console.WriteLine("Enter Character Name: ");
            string? name = Console.ReadLine();
            //Relationship status
            Console.WriteLine("Enter Relationship to Mario: ");
            string? Relationship = Console.ReadLine();
            sw.WriteLine("{0}|{1}|{2}",id, name, Relationship);
        }
        sw.Close();
    }
}while(choice == "1"||choice == "2");