using instapoor_api.Lib;
using instapoor_api.Models;
using instapoor_api.Type;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace instapoor_api.Seeding;

public class Seeding
{


    public void SeedProfile(string cnn)
    {

        var client = new MongoClient(cnn);
        var db = client.GetDatabase("instapoor");

        var pf = db.GetCollection<ProfileModel>("profile");

        IEnumerable<ProfileModel> profiles = [
            new ProfileModel
            {
                identify = "Jose",
                picture = "/picture/GR1BSEsXQAEJYEo.png",
                username = "Gotico"
            },
            new ProfileModel
            {
                identify = "gase",
                picture = "/picture/ganzo.jpeg",
                username = "Gase"
            },
            new ProfileModel
            {
                identify = "amai",
                picture = "/picture/amai.jpeg",
                username = "甘い"
            },
            new ProfileModel
            {
                identify = "nideaboy",
                picture = "/picture/nideaboy.jpg",
                username = "When no tienes idea"
            },
            new ProfileModel
            {
                identify = "Miguel",
                picture = "/picture/GR6aAgpXMAAl8XV.jpg",
                username = "Galleta"
            },
            new ProfileModel
            {
                identify = "Jesus",
                picture = "/picture/GR6SCtNbEAEe8Vp.jpg",
                username = "Sanphutin"
            },
            new ProfileModel
            {
                identify = "kersus",
                picture = "/picture/kersus.jpeg",
                username = "kersus"
            },
            new ProfileModel
            {
                identify = "angelo_lopez_2007",
                picture = "/picture/angel.jpg",
                username = "Angelo Lopez"
            },
            new ProfileModel
            {
                identify = "blsyeon",
                picture = "/picture/sami.jpg",
                username = "Sami"
            }
         ];


        pf.InsertMany(profiles);

        Console.WriteLine("Se Insertaron los datos de perfil");
    }

    public void SeedPost(string cnn)
    {
        var client = new MongoClient(cnn);
        var db = client.GetDatabase("instapoor");


        var pt = db.GetCollection<PostModel>("post");

        IEnumerable<PostModel> post = [
            new PostModel {
                alt = "que bonito gato",
                content = ["/post/meme14.jpg", "/post/meme15.jpg"],
                like = 5,
                time_created = DateTime.Now,
                coment = [
                    new PostComentDTO {
                        message= "Nah, callate un rato",
                        user = new PostUserDTO
                        {
                            identify = "Jose",
                            picture = "/picture/GR1BSEsXQAEJYEo.png",
                            username = "Gotico"
                        },
                        respond = [
                            new PostRespondDTO
                            {
                                to = "Jose",
                                message = "Te voy a golpear",
                                user = new PostUserDTO
                                {
                                    identify = "Jesus",
                                    picture = "/picture/GR6SCtNbEAEe8Vp.jpg",
                                    username = "Sanphutin"
                                }
                            }
                        ]
                    }
                ],
                 user = new PostUserDTO {
                    identify = "Jose",
                    picture = "/picture/GR1BSEsXQAEJYEo.png",
                    username = "Gotico"
                 }
            },
            new PostModel {
                alt = "Jugando un ratico",
                content = ["/post/juganding.mkv"],
                like = 130,
                time_created = DateTime.Now.AddDays(-1),
                coment = [
                    new PostComentDTO {
                        message= "El real caos, que fue",
                        user = new PostUserDTO
                        {
                            identify = "pato",
                            picture = "/picture/ganzo.jpeg",
                            username = "Ganzo"
                        },
                        respond = [
                            new PostRespondDTO
                            {
                                to = "pato",
                                message = "Eip",
                                user = new PostUserDTO
                                {
                                    identify = "nideaboy",
                                    picture = "/picture/nideaboy.jpg",
                                    username = "When no tienes idea"
                                }
                            }
                        ]
                    },
                     new PostComentDTO {
                        message= "Desactiva la cuenta",
                        user = new PostUserDTO
                        {
                            identify = "kersus",
                            picture = "/picture/kersus.jpeg",
                            username = "kersus"
                        },
                        }
                ],
                 user = new PostUserDTO {
                    identify = "nideaboy",
                    picture = "/picture/nideaboy.jpg",
                    username = "When no tienes idea"
                },
            },
            new PostModel {
                alt = "Chispas",
                content = ["/post/dibujossami.png", "/post/dibujossami2.png", "/post/dibujossami3.png"],
                like = 10,
                time_created = DateTime.Now.AddDays(-3),
                coment = [
                    new PostComentDTO {
                        message= "Opa",
                        user = new PostUserDTO
                        {
                            identify = "kersus",
                            picture = "/picture/kersus.jpeg",
                            username = "kersus"
                        },

                    },
                    new PostComentDTO {
                        message= "Aqui esta de donde saque los dibujos original <a href='https://www.instagram.com/blsyeon/'>blsyeon</a> 😈💅",
                        user = new PostUserDTO
                       {
                            identify = "nideaboy",
                            picture = "/picture/nideaboy.jpg",
                            username = "When no tienes idea"
                       },

                    }
                ],
                 user = new PostUserDTO {
                    identify = "blsyeon",
                    picture = "/picture/sami.jpg",
                    username = "Sami"
                }
            },
            new PostModel {
                alt = "Dibujos que hice",
                content = ["/post/dibujogase.jpg", "/post/dibujogase2.jpg", "/post/dibujogase3.jpg"],
                like = 5,
                time_created = DateTime.Now,
                coment = [
                    new PostComentDTO {
                        message= "Zzzz",
                        user = new PostUserDTO
                        {
                            identify = "kersus",
                            picture = "/picture/kersus.jpeg",
                            username = "kersus"
                        },
                        respond = [
                            new PostRespondDTO
                            {
                                to = "kersus",
                                message ="se donde vives 😈⛏️",
                                user = new PostUserDTO
                                {
                                    identify = "amai",
                                    picture = "/picture/amai.jpeg",
                                    username = "甘い"
                                },
                            }
                        ]
                    },
                    new PostComentDTO {
                        message= "Lamentablemente no tiene cuenta de dibujo pero les puedo dar un nombre: gase 🦴💅",
                        user = new PostUserDTO
                        {
                            identify = "nideaboy",
                            picture = "/picture/nideaboy.jpg",
                            username = "When no tienes idea"
                        },
                    }
                ],
                 user = new PostUserDTO {
                    identify = "gase",
                    picture = "/picture/ganzo.jpeg",
                    username = "Gase"
                },
            },
            new PostModel {
                alt = "La portada del libro que estoy escribiendo",
                content = ["/post/368641897-352-k933480.jpg"],
                like = 140,
                time_created = DateTime.Now.AddDays(-4),
                coment = [
                    new PostComentDTO {
                        message= "Deam",
                        user = new PostUserDTO
                        {
                            identify = "kersus",
                            picture = "/picture/kersus.jpeg",
                            username = "kersus"
                        },
                    },
                    new PostComentDTO {
                        message= "Aqui esta los link del creador original <a href='https://m.facebook.com/61551178917186/'>facebook</a> <a href='https://www.wattpad.com/user/Angelo_LOPEZ_2007?utm_source=android&utm_medium=link&utm_content=share_profile&wp_page=user_details&wp_uname=Jeff22387&fbclid=PAZXh0bgNhZW0CMTEAAaYMaFBSOQ0TAQdIt2bkgoDGWFHY0vn00wWmqNTmxvciGf0QNimvoiZZL20_aem_rNFMlfNh5cyLLQgdKuVKRA'>whatpad</a> y por ultimo <a href='https://www.tiktok.com/@jeff_lopez22?_t=8n62sj1LvBm&_r=1&fbclid=PAZXh0bgNhZW0CMTEAAaaA_NgC4lUqe3th6cQiP2nPnQStF8pXOzhwilRJMm8Dc1upx-MS6Fwja1g_aem_A2JDSUnKmRxJcHjM-LnpvQ'>tick tock</a> 😈💅",
                        user = new PostUserDTO
                        {
                            identify = "nideaboy",
                            picture = "/picture/nideaboy.jpg",
                            username = "When no tienes idea"
                        },
                    }
                ],
                 user = new PostUserDTO {
                    identify = "angelo_lopez_2007",
                    picture = "/picture/angel.jpg",
                    username = "Angelo Lopez"
                },
            },
            new PostModel {
                alt = "",
                content = ["/post/imagen1"],
                like = 5,
                time_created = DateTime.Now,
                coment = [
                    new PostComentDTO {
                        message= "Nah, callate un rato",
                        user = new PostUserDTO
                        {
                            identify = "Jose",
                            picture = "/picture/GR1BSEsXQAEJYEo.png",
                            username = "Gotico"
                        },
                        respond = [
                            new PostRespondDTO
                            {
                                to = "Jose",
                                message = "true",
                                user = new PostUserDTO
                                {
                                    identify = "Jesus",
                                    picture = "/picture/GR6SCtNbEAEe8Vp.jpg",
                                    username = "Sanphutin"
                                }
                            },
                            new PostRespondDTO
                            {
                                to = "Jose",
                                message = "Mi nombre es jhon alejandro y soy esquizofrenico",
                                user = new PostUserDTO
                               {
                                    identify = "Miguel",
                                    picture = "/picture/GR6aAgpXMAAl8XV.jpg",
                                    username = "Galleta"
                            },
                            }
                        ]
                    }
                ],
                 user = new PostUserDTO {
                    identify = "Jose",
                    picture = "/picture/GR1BSEsXQAEJYEo.png",
                    username = "Gotico"
                 }
            },
            new PostModel {
                alt = "Quien dijo que fornite es zzz",
                content = ["/post/meme9.jpg"],
                like = 0,
                time_created = DateTime.Now,
                coment = [],
                 user = new PostUserDTO {
                    identify = "Miguel",
                    picture = "/picture/GR6aAgpXMAAl8XV.jpg",
                    username = "Galleta"
                },
            },
            new PostModel {
                alt = "yo",
                content = ["/post/yo.jpg"],
                like = 15,
                time_created = DateTime.Now,
                coment = [],
                 user = new PostUserDTO {
                    identify = "nideaboy",
                    picture = "/picture/nideaboy.jpg",
                    username = "When no tienes idea"
                },
            }
        ];
        pt.InsertMany(post);
        Console.WriteLine("Se Insertaron los post");
    }
}