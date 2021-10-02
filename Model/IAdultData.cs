using System.Collections.Generic;

namespace Model
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void UpdateAdult(Adult adult);//to add parametres
        void RemoveAdult(int personId);
    }
}