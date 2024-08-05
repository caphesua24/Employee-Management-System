using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Class
{
	public class Encryption
	{
		public string EndcodeMD5(string Password)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

			byte[] bs = System.Text.Encoding.UTF8.GetBytes(Password);

			bs = md5.ComputeHash(bs);
			System.Text.StringBuilder s = new System.Text.StringBuilder();
			foreach (byte b in bs)
			{
				s.Append(b.ToString("x1").ToLower());
			}

			return Password;
		}

		public string GetMD5(string text)
		{
			UnicodeEncoding UE = new UnicodeEncoding();
			byte[] hashValue;
			byte[] message = UE.GetBytes(text);

			MD5 hashString = new MD5CryptoServiceProvider();
			string hex = "";

			hashValue = hashString.ComputeHash(message);
			foreach(byte x in hashValue)
			{
				hex += string.Format("{0:x2}", x);
			}
			return hex;
		}

		public string EndcodeSHA1(string password)
		{
			SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

			byte[] bs = System.Text.Encoding.UTF8.GetBytes(password);
			bs = sha1.ComputeHash(bs);
			System.Text.StringBuilder s = new StringBuilder();
			foreach(byte b in bs)
			{
				s.Append(b.ToString("x1").ToLower());
			}
			password = s.ToString();
			return password;
		}
		
		public string EndcodeSHA256(string password)
		{
			UnicodeEncoding sha256 = new UnicodeEncoding();

			byte[] hashValue;
			byte[] message = sha256.GetBytes(password);

			SHA1Managed hashString  = new SHA1Managed();
			string hex = "";

			hashValue = hashString.ComputeHash(message);
			foreach(byte b in hashValue)
			{
				hex += string.Format("{0:x2}", b);
			}
			return hex;
		}

		public string EndcodeSHA512(string password)
		{
			UnicodeEncoding sha512 = new UnicodeEncoding();

			byte[] hashValue;
			byte[] message = sha512.GetBytes(password);

			SHA512Managed hashString = new SHA512Managed();
			string hex = "";

			hashValue = hashString.ComputeHash(message);
			foreach(byte b in hashValue)
			{
				hex += string.Format("{0:x2}",b);
			}
			return hex;
		}
	}
}
