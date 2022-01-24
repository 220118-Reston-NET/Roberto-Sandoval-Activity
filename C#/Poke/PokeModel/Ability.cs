namespace PokeModel
{
    public class Ability
    {
        public string Name { get; set; }
        private int _PP;
        public int PP
        {
            get { return _PP; }
            set { 
                if (value > 0) {
                    _PP = value; 
                    
                } else {
                    throw new System.Exception("You cannot set PP lower than 0");
                }
            }
        }

        public int Power { get; set; }
        public int Accuracy { get; set; }
        

        
    }
}