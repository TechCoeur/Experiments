namespace confusionrestaurant.Entities
{
    public class Comment
    {
        public int CommentId {get; set;}
        public int Rating {get; set;}
        public string DishComment {get; set;}
        public CrUser User {get; set;}
        public Dish Dish {get; set;}

    }
}