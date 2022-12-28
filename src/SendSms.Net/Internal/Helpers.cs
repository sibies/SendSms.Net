using System.Globalization;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace SendSms.Net.Internal;
public static class Helpers
{

    //public function validatePhone($phone)
    //{
    //    $phone = preg_replace('/\D/', '', $phone);
    //    if (substr($phone, 0, 1) == '0' && strlen($phone) == 10)
    //    {
    //        $phone = '4'.$phone;
    //    }
    //    elseif(substr($phone, 0, 1) != '0' && strlen($phone) == 9) {
    //        $phone = '40'.$phone;
    //    }
    //    elseif(strlen($phone) == 13 && substr($phone, 0, 2) == '00') {
    //        $phone = substr($phone, 2);
    //    }
    //    return $phone;
    //}

    /// <summary>
    /// https://github.com/sendSMS-RO/sendsms-opencart/blob/master/admin/model/extension/sendsms/send.php
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    static string ValidatePhone(string phone)
    {
        return string.Empty;
    }

    static string RemoveDiacritics(this string text)
    {
        if (text == null)
            return string.Empty;

        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }

    public static string ToUtf8(this string text)
    {
        return text == null ? string.Empty : Encoding.UTF8.GetString(Encoding.Default.GetBytes(text));
    }


}