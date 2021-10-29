﻿using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FaceRepository : RepositoryBase<Face>, IFaceRepository
    {
        public FaceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}