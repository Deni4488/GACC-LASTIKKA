using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using gacc;
using System.Net;
using Xunit;
namespace gacc.Tests
{
    public class AuthorizationTests
    {
        private readonly Authorization _authorizationService = new Authorization();

        // Тест на успешную авторизацию
        [Test]
        public void TestValidLogin()
        {
            var result = _authorizationService.Login("validUser", "correctPassword");

            Assert.IsTrue(result);
        }

        // Тест на неверный пароль
        [Test]
        public void TestInvalidPassword()
        {
            var result = _authorizationService.Login("validUser", "wrongPassword");

            Assert.IsFalse(result);
        }

        // Тест на несуществующего пользователя
        [Test]
        public void TestNonExistingUser()
        {
            var result = _authorizationService.Login("nonexistentUser", "password");

            Assert.IsFalse(result);
        }

        // Дополнительные тесты...
    }
}
}
