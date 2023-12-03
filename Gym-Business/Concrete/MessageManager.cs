using System;
using Gym_Business.Abstract;
using Gym_Data.Abstract;
using Gym_Entity.Concrete;

namespace Gym_Business.Concrete
{
    public class MessageManager : IMessageService
    {
        public IMessageDAL _messageDal;

        public MessageManager(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

        public void SDelete(Message s)
        {
            _messageDal.Delete(s);
        }

        public Message SGetByID(int ID)
        {
            return _messageDal.GetByID(ID);
        }

        public List<Message> SGetList()
        {
            return _messageDal.GetList();
        }

        public void SInsert(Message s)
        {
            _messageDal.Insert(s);
        }

        public void SUpdate(Message s)
        {
            _messageDal.Update(s);
        }
    }
}

