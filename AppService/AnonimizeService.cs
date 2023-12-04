using Core;
using Infra;
using System;
using System.Collections.Generic;

namespace AppService
{
    public class AnonimizeService
    {
        private readonly ClubRepository _repository;

        public AnonimizeService()
        {
            _repository = new ClubRepository();
        }

        public List<ClubRegister> GetClubRegisters()
        {
            return _repository.GetClubRegisters();
        }

        public bool Anonimize(AnonimizeRequest request)
        {
            if (request == null || request.Fields.Count < 1)
                return false;

            var data = _repository.GetClubRegisters();

            foreach (var item in request.Fields)
            {
                if (item.Equals("name", StringComparison.InvariantCultureIgnoreCase))
                    AnonimizeName(data);
                else if (item.Equals("cellphone", StringComparison.InvariantCultureIgnoreCase))
                    AnonimizeCellphone(data);
                else if (item.Equals("email", StringComparison.InvariantCultureIgnoreCase))
                    AnonimizeEmail(data);
                else
                    continue;
            }

            return true;
        }

        private void AnonimizeName(List<ClubRegister> data)
        {
            foreach (var item in data)
            {
                item.User.Name = "*********";
            }
        }

        private void AnonimizeCellphone(List<ClubRegister> data)
        {
            foreach (var item in data)
            {
                item.User.CellPhone = "*********";
            }
        }

        private void AnonimizeEmail(List<ClubRegister> data)
        {
            foreach (var item in data)
            {
                try
                {
                    var emailParts = item.User.Email.Split("@");

                    item.User.Email = $"*********@{emailParts[1]}";
                }
                catch (Exception ex)
                {
                    item.User.Email = "*********";
                }
            }
        }
    }
}
