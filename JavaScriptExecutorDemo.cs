            // sending text to a text field using JSE:
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

            IJavaScriptExecutor ijse = driver as IJavaScriptExecutor;


            
        ijse.ExecuteScript("document.getElementById('email').value='armel@ramesh.com';");

            ijse.ExecuteScript("window.scrollTo(0,6000)");



            // Getting the page title using JSE:
            String sText = ijse.ExecuteScript("return document.title;").ToString();
            Console.WriteLine(sText);

            // Getting the page domain using JSE:
            String sDom = ijse.ExecuteScript("return document.domain;").ToString();
            Console.WriteLine(sDom);
