﻿using MediatR;

namespace mediator_app2_mediatr_and_cqrs.Notifications;

public class ProdutoCreateNotification : INotification
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
