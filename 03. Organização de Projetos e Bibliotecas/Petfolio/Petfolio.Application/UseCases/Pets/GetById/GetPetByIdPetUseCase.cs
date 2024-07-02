﻿using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdPetUseCase
{
    public ResponsePetJson Execute(int id)
    { 
        return new ResponsePetJson
        {
            Id = id,
            Name = "Betle",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2023, month: 01, day: 01)
        };
    }
}
