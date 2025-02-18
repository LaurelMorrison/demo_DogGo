﻿using DogGo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);

        Owner GetOwnerByEmail(string email);

        void AddOwner(Owner owner);

        void UpdateOwner(Owner owner);

        void DeleteOwner(int ownerId);

    }

}

