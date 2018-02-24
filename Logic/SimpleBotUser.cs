using SimpleBot.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleBot.Entity;
using SimpleBot.Repository.MongoRepositories;

namespace SimpleBot
{
    public class SimpleBotUser
    {
        public static string Reply(Message message)
        {
            var profile = UserProfileRepository.Instance.BuscaPorId(message.Usuario);
            if (profile == null)
            {
                UserProfileRepository.Instance.Inserir(new UserProfile()
                {
                    EntityId = message.Usuario,
                    Visitas = 0,
                });
            }
            var resposta = $"{message.Usuario} disse '{message.Texto}' e falou conosco : { profile.Visitas} vezes";

            profile.Visitas++;
            UserProfileRepository.Instance.Atualizar(profile);

            MessageRepositoryMongo.Instance.Inserir(message);

            return resposta;
        }

        public static UserProfile GetProfile(string id)
        {
            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {
        }
    }
}