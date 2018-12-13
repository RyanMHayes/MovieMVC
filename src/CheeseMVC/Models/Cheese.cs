namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CheeseType Type { get; set; }
        public int ID { get; set; } //This was here to begin with.  I added the below material
                                    //to match the video.  

        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }

    }
}
