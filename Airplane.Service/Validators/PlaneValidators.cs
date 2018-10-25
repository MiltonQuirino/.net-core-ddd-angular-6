using System;
using Airplane.Domain.Entities;
using FluentValidation;

namespace Airplane.Service
{
    public class PlaneValidators : AbstractValidator<Plane>
    {
        public PlaneValidators()
        {
            RuleFor(x => x)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto não encotrado.");
                });
            RuleFor(x => x.Capacity)
                .NotEmpty().WithMessage("É necessario informar a capacidade.")
                .NotNull().WithMessage("É necessario informar a capacidade.");

            RuleFor( x=> x.CreatedAt)
                .NotEmpty().WithMessage("É necessario informar a data de criação.")
                .NotNull().WithMessage("É necessario informar a data de criação.");

            RuleFor( x=> x.Model)
                .NotEmpty().WithMessage("É necessario informar o modelo.")
                .NotNull().WithMessage("É necessario informar o modelo.");


        }
    }
}
