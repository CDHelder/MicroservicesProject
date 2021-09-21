﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepository repository;
        private readonly IMapper mapper;

        public PlatformsController(IPlatformRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDTOs>> GetPlatforms()
        {
            Console.WriteLine("--> Getting Platforms.... ");

            var platformItem = repository.GetAll();

            return Ok(mapper.Map<IEnumerable<PlatformReadDTOs>>(platformItem));
        }

        [HttpGet("{id}", Name = "GetPlatformById")]
        public ActionResult<PlatformReadDTOs> GetPlatformById(int id)
        {
            var platformItem = repository.GetById(id);

            if (platformItem != null)
            {
                return Ok(mapper.Map<PlatformReadDTOs>(platformItem));
            }

            return NotFound();
        }
    }
}
