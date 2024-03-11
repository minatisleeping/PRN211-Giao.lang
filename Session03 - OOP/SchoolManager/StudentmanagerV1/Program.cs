using StudentmanagerV1.Entities;

namespace StudentmanagerV1;
class Program
{
    static void Main(string[] args)
    {
        //create an object from a mold/template
        //we need material to fill-in (parameter for a method)
        //we need use the funnel - dùng phễu - to call the constructor - the same meaning
        CreateAStudentV1();
    }

    static void CreateAStudentV4()
    {

        Student an = new(gpa: 8.8, yob: 2003, id: "SE1", name: "An Nguyễn", email: "ann@fpt.edu.vn");

        an.ShowProfile();
        //named-argument: pass parameters in a method in a flexible
        //order, by given the name of parameter accompanies withj value

    }

    static void CreateAStudentV3()
    {

        Student an = new("SE1", "An Nguyễn", 2003, "ann@fpt.edu.vn", 8.8);

        an.ShowProfile();
    }

    static void CreateAStudentV2()
    {
        
        var an = new Student("SE1", "An Nguyễn", 2003, "ann@fpt.edu.vn", 8.8);
        
        an.ShowProfile();
        //var na means an has the data type of Student
        //runtime will update an data type based on the assigned value
    }

    static void CreateAStudentV1()
    {
        //we name everything around us. Ta có thói quen đặt tên cho mọi thứ quanh ta
        //even the thing is a single value or a complex value - object
        //3.14 -> PI
        //10%  -> VAT
        //9.8  -> g(gravity)
        //s = v * t (t: time; v: velocity)
        //Messi -> (name..dob..goals.. awards..)
        //CR7   -> (name..dob..goals.. awards..)
        //a name to make easy to communicate with
        Student an = new Student("SE1", "An Nguyễn", 2003, "ann@fpt.edu.vn", 8.8);
        //an: the name of a complex value
        //new Student("SE1", "An Nguyễn", 2003, "ann@fpt.edu.vn", 8.8); -> complex value, an object

        an.ShowProfile();
    }
}

