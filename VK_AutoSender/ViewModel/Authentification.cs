using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using VK_AutoSender.Model;
using VK_AutoSender.View;
using VkNet;
using VkNet.AudioBypassService.Extensions;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace VK_AutoSender.ViewModel
{
    public class Authentification
    {
        private static bool IsAuth(VkApi vkApi) => vkApi.IsAuthorized;

        private static VkApi GetVkApi()
        {
            var services = new ServiceCollection();
            services.AddAudioBypass();
            var vkApi = new VkApi(services);
            return vkApi;
        }

        public static (bool, Exception, VkApi) AuthLoginVerify(string login, string password, ulong appID)
        {
            login = "89286287213";
            password = "23792379Bn7@";
            appID = 51741529;

            var vkApi = GetVkApi();

            try
            {
                vkApi.Authorize(new ApiAuthParams
                {
                    ApplicationId = appID,
                    Login = login,
                    Password = password,
                    Settings = Settings.All,
                    TwoFactorAuthorization = SecondTwoFactorAuthorization
                }
                );
            }
            catch (Exception e)
            {
                return (IsAuth(vkApi), e, null);
            }

            new UserData(login, password, appID, vkApi.UserId.Value);
            new UserData(vkApi.Token);

            return (IsAuth(vkApi), null, vkApi);
        }

        public static (bool, Exception, VkApi) AuthTokenVerify(string token)
        {
            var vkApi = GetVkApi();

            try
            {
                vkApi.Authorize(new ApiAuthParams
                {
                    AccessToken = token
                }
                );
            }
            catch (Exception e)
            {
                return (IsAuth(vkApi), e, null);
            }

            return (IsAuth(vkApi), null, vkApi);
        }

        private static string SecondTwoFactorAuthorization()
        {
            string result = "";

            Thread t = new Thread(() =>
            {
                EnterCodeForm form = new EnterCodeForm();
                if (form.ShowDialog() == true)
                {
                    result = form.code.Text;
                }
            });

            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;

            t.Start();
            t.Join();

            return result;
        }
    }
}

//vk1.a.CdazeUeL3ZUntGbOQFzuDxIk4PSdFHRBV9gAZrwVBbnbzcz-M1X-O2fZRXcDaAchRYLd6t6aQFT29ifOupEm6G_UwoOyWQatsOr3bgIO_dU0wxKdi6NhRwbBnWdW6Joxjf112ZAmC5oJBvPNZJ_4bPqJQGorIEQBs914gEb9Oht_CkLdrinQ-bdeC_Cpj6ha
//51736786 51741409
//89034032693
//Bn7@23792379Bn7@YellowArrow_Vkontakte
//UserId = 291962925,