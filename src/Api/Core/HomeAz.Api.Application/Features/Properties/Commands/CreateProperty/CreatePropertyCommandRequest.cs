﻿using HomeAz.Api.Domain.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAz.Api.Application.Features.Properties.Commands.CreateProperty
{
    public class CreatePropertyCommandRequest : IRequest
    {
        public List<IFormFile> Images { get; set; }
        public bool Status { get; set; }
        public PropertyTypes Type { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public float Price { get; set; }
        public short NumberOfBathrooms { get; set; }
        public short NumberOfBedrooms { get; set; }
        public float SquareMeters { get; set; }
    }
}