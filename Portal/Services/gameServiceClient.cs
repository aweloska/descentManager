﻿using System.Collections.Generic;
using Descent.Web.Models;

namespace Descent.Web.Services
{
    public class GameServiceClient : IGameServiceClient
    {
        private const string ServicePath = "game";

        public List<GameModel> GetGames(string email)
        {
            var game = new List<GameModel>
            {
                new GameModel
                {
                    Id = "1",
                    Name = "Game with Gonzalo and Pablo",
                    Notes = "some long text, this text can be very long it's used for taking some notes",
                    User = email,
                    CharacterImage = "Content/images/thumbnails/Heroes/LeoricoftheBook.png",
                    Objects = new List<CardModel>
                    {
                        new CardModel {Id = "1", Url = "Content/images/thumbnails/pdf.png"},
                        new CardModel {Id = "2", Url = "Content/images/thumbnails/cls.png"}
                    },
                    Skills = new List<CardModel>
                    {
                        new CardModel {Id = "1", Url = "Content/images/thumbnails/doc.png"},
                        new CardModel {Id = "2", Url = "Content/images/thumbnails/draft.png"}
                    },
                    Users = new List<UserModel>
                    {
                        new UserModel {Id = "1", Name = "Migue", Value = "aweloska@gmail.com"},
                        new UserModel {Id = "2", Name = "Juanga", Value = "juangabreil@gmail.com"}
                    }
                }
            };

            return game;
        }
    }
}