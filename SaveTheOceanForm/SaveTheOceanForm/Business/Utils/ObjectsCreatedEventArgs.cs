using SaveTheOceanForm.Business.Entities;

namespace SaveTheOceanForm.Business.Utils
{
    public class ObjectsCreatedEventArgs : EventArgs
    {
        public Rescue? RescueObject { get; set; }
        public object? AnimalObject { get; set; }

        public ObjectsCreatedEventArgs(Rescue? rescueObject, object? animalObject)
        {
            RescueObject = rescueObject;
            AnimalObject = animalObject;
        }
    }
}
