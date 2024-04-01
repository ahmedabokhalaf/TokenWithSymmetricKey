namespace TokenUsingSymmetricKey
{
    class Program
    {
        static int Main(string[] args)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Console.WriteLine("Please enter a string for encryption");
            string userId = "0f0243de-f27e-4a24-8f74-85e4182df672";
            var date = DateTime.Now.AddMinutes(5);
            var provider = "ForgetPassword";
            var token = $"{userId}${date}${provider}";
            var encryptedString = AESOperations.EncryptionString(key, token);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = AESOperations.DecryptionString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();
            return 0;
        }
    }
    
}