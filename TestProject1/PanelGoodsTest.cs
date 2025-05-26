using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using gacc.Panels;

namespace TestProject1
{
    internal class PanelGoodsTest
    {
        [Test]
        public void Test_Delete_Successful()
        {
            // Arrange
            var productManager = new PanelGoods();

            // Mock для DataGridView
            var dataGridViewMock = new Mock<DataGridView>();
            var rowsCollectionMock = new Mock<DataGridViewRowCollection>(dataGridViewMock.Object);
            var rowMock = new Mock<DataGridViewRow>();
            var cellMock = new Mock<DataGridViewCell>();

            cellMock.SetupGet(c => c.Value).Returns(1); // Устанавливаем значение ячейки
            rowMock.Setup(r => r.Cells[It.IsAny<int>()]).Returns(cellMock.Object);
            rowsCollectionMock.Setup(rc => rc.Count).Returns(1);
            rowsCollectionMock.Setup(rc => rc[0]).Returns(rowMock.Object);
            dataGridViewMock.Setup(dgv => dgv.SelectedRows).Returns(new[] { rowMock.Object });
            dataGridViewMock.Setup(dgv => dgv.Rows).Returns(rowsCollectionMock.Object);

            // Mock для базового класса DBImage.gta и диалоговых окон
            var messageBoxMock = new Mock<MessageBox>();
            messageBoxMock.Setup(mb => mb.Show(It.IsAny<string>(), It.IsAny<string>(),
                                              It.IsAny<MessageBoxButtons>(), It.IsAny<MessageBoxIcon>()))
                         .Returns(DialogResult.Yes);

            Authorization.Access = 3; // Предоставляем доступ достаточный для удаления

            // Act
            productManager.TsbtnDeleteClick(dataGridViewMock.Object, null, null);

            // Assert
            // Здесь проверка результатов
            // Например, проверить было ли вызвано DeleteQuery
            // Это требует рефакторинга вашего проекта, чтобы сделать зависимость доступной для тестов
            // Если интерфейс интерфейсов изолирован (например, через DI), то используем Moq для тестирования взаимодействий
        }

        [Test]
        public void Test_Delete_InsufficientRights()
        {
            // Arrange
            var productManager = new ProductManager();
            var dataGridViewMock = new Mock<DataGridView>();
            Authorization.Access = 1; // Ограничиваем доступ

            // Act
            productManager.TsbtnDeleteClick(dataGridViewMock.Object, null, null);

            // Assert
            // Проверяем сообщение об ошибке, показанное пользователю
            // Для этого нужен mock для MessageBox
        }

        [Test]
        public void Test_Delete_NoSelectedRow()
        {
            // Arrange
            var productManager = new ProductManager();
            var dataGridViewMock = new Mock<DataGridView>();
            dataGridViewMock.Setup(dgv => dgv.SelectedRows).Returns(new DataGridViewSelectedRowCollection());
            Authorization.Access = 3;

            // Act
            productManager.TsbtnDeleteClick(dataGridViewMock.Object, null, null);

            // Assert
            // Убедимся, что ничего не произошло, поскольку нет выделенной строки
        }
    }
}
