namespace OrderMicroservideTests
{
    [TestClass]
    
    public class OrderControllerTest
    {
        //private readonly OrdersController _controller;
        //private readonly IOrderRepository _repository;

        public OrderControllerTest()
        {
           // _repository = new OrderRepository();
            //_controller = new OrdersController(_repository);
        }


        [TestMethod]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Arrange 



            // Act


            // Assert
        }

       

        [TestMethod]
        public void Get_WhenCalled_ReturnsAllOrders()
        {

            //Arrange 



            // Act


            // Assert
        }

        [TestMethod]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            //Arrange 



            // Act


            // Assert
        }


        [TestMethod]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {

            //Arrange 



            // Act


            // Assert

        }


        [TestMethod]
        public void GetById_ExistingIdPassed_ReturnsRightOrder()
        {
            //Arrange 



            // Act


            // Assert
        }



        [TestMethod]
        public void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            //Arrange 



            // Act


            // Assert
        }


        [TestMethod]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            //Arrange 



            // Act


            // Assert

        }



        [TestMethod]
        public void Add_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            //Arrange 



            // Act


            // Assert
        }



        [TestMethod]
        public void Remove_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            //Arrange 



            // Act


            // Assert
        }


        [TestMethod]
        public void Remove_ExistingIdPassed_ReturnsNoContentResult()
        {
            //Arrange 



            // Act


            // Assert
        }
    }
}