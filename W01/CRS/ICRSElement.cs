namespace CRS
{
    public interface ICRSElement
    {
        // READ
        string toString();
        string toJson();

        // UPDATE
        void update();
        
        // DELETE
        string delete();
    }
}