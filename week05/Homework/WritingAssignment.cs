public class WritingAssignment : Assignment
{
   private string _title;

   public WritingAssignment(string studentName,string topic, string title ) : base(studentName, topic)
   {
        _title = title;
   }

   public string Title
   {
        get { return _title; }
        set { _title = value; }
   }

   public string GetWritingInformation()
   {
    return  "Student Name: " + StudentName +"\n" +
            "Topic: " + Topic + "\n" +
            "Title: " + _title + "\n";
           
   }

}