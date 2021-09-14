using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Tests
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document inValidDocument;

        public DocumentTests()
        {
            validDocument = new Document("71375763032");
            inValidDocument = new Document("12345678910");

        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotValid()
        {
            Assert.AreEqual(false, inValidDocument.IsValid);
            Assert.AreEqual(1, inValidDocument.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsValid()
        {
            Assert.AreEqual(true, validDocument.IsValid);
            Assert.AreEqual(0, validDocument.Notifications.Count);
        }
    }
}
