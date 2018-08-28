using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class InitialEfCoreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "tags",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "tags",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "syntaxes",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "syntaxes",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "software_syntaxes",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "software",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "software",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "rules",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "merges",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "maintainers",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "maintainers",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "licenses",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "licenses",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "languages",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "languages",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "forks",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists_tags",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists_maintainers",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists_languages",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "filterlists",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists",
                "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.InsertData(
                "languages",
                new[]
                {
                    "Id", "CreatedDateUtc", "Iso6391", "Iso6392", "Iso6392B", "Iso6392T", "Iso6393", "LocalName",
                    "ModifiedDateUtc", "Name"
                },
                new object[,]
                {
                    {(ushort)1, null, "ab", "abk", "abk", "abk", "abk", "Аҧсуа", null, "Abkhaz"},
                    {(ushort)118, null, "af", "afr", "afr", "afr", "afr", "Afrikaans", null, "Afrikaans"},
                    {(ushort)119, null, "ak", "aka", "aka", "aka", "aka", "Akan", null, "Akan"},
                    {(ushort)120, null, "sq", "sqi", "alb", "sqi", "sqi", "Shqip", null, "Albanian"},
                    {(ushort)121, null, "am", "amh", "amh", "amh", "amh", "አማርኛ", null, "Amharic"},
                    {(ushort)122, null, "ar", "ara", "ara", "ara", "ara", "العربية", null, "Arabic"},
                    {(ushort)123, null, "an", "arg", "arg", "arg", "arg", "Aragonés", null, "Aragonese"},
                    {(ushort)124, null, "hy", "hye", "arm", "hye", "hye", "Հայերեն", null, "Armenian"},
                    {(ushort)125, null, "as", "asm", "asm", "asm", "asm", "অসমীয়া", null, "Assamese"},
                    {(ushort)126, null, "av", "ava", "ava", "ava", "ava", "Авар", null, "Avaric"},
                    {(ushort)127, null, "ae", "ave", "ave", "ave", "ave", "avesta", null, "Avestan"},
                    {(ushort)128, null, "ay", "aym", "aym", "aym", "aym", "Aymar", null, "Aymara"},
                    {(ushort)129, null, "az", "aze", "aze", "aze", "aze", "Azərbaycanca", null, "Azerbaijani"},
                    {(ushort)130, null, "bm", "bam", "bam", "bam", "bam", "Bamanankan", null, "Bambara"},
                    {(ushort)131, null, "ba", "bak", "bak", "bak", "bak", "Башҡортса", null, "Bashkir"},
                    {(ushort)132, null, "eu", "eus", "baq", "eus", "eus", "Euskara", null, "Basque"},
                    {(ushort)133, null, "be", "bel", "bel", "bel", "bel", "Беларуская", null, "Belarusian"},
                    {(ushort)134, null, "bn", "ben", "ben", "ben", "ben", "বাংলা", null, "Bengali"},
                    {(ushort)135, null, "bh", "bih", "bih", "bih", "bih", "भोजपुरी", null, "Bihari"},
                    {(ushort)136, null, "bs", "bos", "bos", "bos", "bos", "Bosanski", null, "Bosnian"},
                    {(ushort)117, null, "aa", "aar", "aar", "aar", "aar", "Afaraf", null, "Afar"},
                    {(ushort)137, null, "fo", "fao", "fao", "fao", "fao", "Føroyskt", null, "Faroese"},
                    {(ushort)116, null, "bi", "bis", "bis", "bis", "bis", "Bislama", null, "Bislama"},
                    {(ushort)114, null, "ee", "ewe", "ewe", "ewe", "ewe", "Eʋegbe", null, "Ewe"},
                    {(ushort)95, null, "ca", "cat", "cat", "cat", "cat", "Català", null, "Catalan"},
                    {(ushort)96, null, "ch", "cha", "cha", "cha", "cha", "Chamoru", null, "Chamorro"},
                    {(ushort)97, null, "ce", "che", "che", "che", "che", "Нохчийн", null, "Chechen"},
                    {(ushort)98, null, "ny", "nya", "nya", "nya", "nya", "Chichewa", null, "Chichewa"},
                    {(ushort)99, null, "zh", "zho", "chi", "zho", "zho", "中文", null, "Chinese"},
                    {(ushort)100, null, "cv", "chv", "chv", "chv", "chv", "Чӑвашла", null, "Chuvash"},
                    {(ushort)101, null, "kw", "cor", "cor", "cor", "cor", "Kernewek", null, "Cornish"},
                    {(ushort)102, null, "co", "cos", "cos", "cos", "cos", "Corsu", null, "Corsican"},
                    {(ushort)103, null, "cr", "cre", "cre", "cre", "cre", "ᓀᐦᐃᔭᐍᐏᐣ", null, "Cree"},
                    {(ushort)104, null, "hr", "hrv", "hrv", "hrv", "hrv", "Hrvatski", null, "Croatian"},
                    {(ushort)105, null, "cs", "ces", "cze", "ces", "ces", "Čeština", null, "Czech"},
                    {(ushort)106, null, "da", "dan", "dan", "dan", "dan", "Dansk", null, "Danish"},
                    {(ushort)107, null, "dv", "div", "div", "div", "div", "Divehi", null, "Divehi"},
                    {(ushort)108, null, "nl", "nld", "dut", "nld", "nld", "Nederlands", null, "Dutch"},
                    {(ushort)109, null, "dz", "dzo", "dzo", "dzo", "dzo", "རྫོང་ཁ", null, "Dzongkha"},
                    {(ushort)110, null, "en", "eng", "eng", "eng", "eng", "English", null, "English"},
                    {(ushort)111, null, "eo", "epo", "epo", "epo", "epo", "Esperanto", null, "Esperanto"},
                    {(ushort)112, null, "et", "est", "est", "est", "est", "Eesti", null, "Estonian"},
                    {(ushort)113, null, "bg", "bul", "bul", "bul", "bul", "Български", null, "Bulgarian"},
                    {(ushort)115, null, "br", "bre", "bre", "bre", "bre", "Brezhoneg", null, "Breton"},
                    {(ushort)138, null, "fj", "fij", "fij", "fij", "fij", "Na Vosa Vaka-Viti", null, "Fijian"},
                    {(ushort)139, null, "fi", "fin", "fin", "fin", "fin", "Suomi", null, "Finnish"},
                    {(ushort)140, null, "iu", "iku", "iku", "iku", "iku", "ᐃᓄᒃᑎᑐᑦ", null, "Inuktitut"},
                    {(ushort)166, null, "ka", "kat", "geo", "kat", "kat", "ქართული", null, "Georgian"},
                    {(ushort)167, null, "de", "deu", "ger", "deu", "deu", "Deutsch", null, "German"},
                    {(ushort)168, null, "el", "ell", "gre", "ell", "ell", "Ελληνικά", null, "Greek"},
                    {(ushort)169, null, "gn", "grn", "grn", "grn", "grn", "Avañe'ẽ", null, "Guaraní"},
                    {(ushort)170, null, "gu", "guj", "guj", "guj", "guj", "ગુજરાતી", null, "Gujarati"},
                    {(ushort)171, null, "ht", "hat", "hat", "hat", "hat", "Kreyòl Ayisyen", null, "Haitian"},
                    {(ushort)172, null, "za", "zha", "zha", "zha", "zha", "Cuengh", null, "Zhuang"},
                    {(ushort)173, null, "ha", "hau", "hau", "hau", "hau", "هَوُسَ", null, "Hausa"},
                    {(ushort)174, null, "hz", "her", "her", "her", "her", "Otjiherero", null, "Herero"},
                    {(ushort)175, null, "hi", "hin", "hin", "hin", "hin", "हिन्दी", null, "Hindi"},
                    {(ushort)176, null, "ho", "hmo", "hmo", "hmo", "hmo", "Hiri Motu", null, "Hiri Motu"},
                    {(ushort)177, null, "hu", "hun", "hun", "hun", "hun", "Magyar", null, "Hungarian"},
                    {(ushort)178, null, "ia", "ina", "ina", "ina", "ina", "Interlingua", null, "Interlingua"},
                    {(ushort)179, null, "id", "ind", "ind", "ind", "ind", "Bahasa Indonesia", null, "Indonesian"},
                    {(ushort)180, null, "ie", "ile", "ile", "ile", "ile", "Interlingue", null, "Interlingue"},
                    {(ushort)181, null, "ga", "gle", "gle", "gle", "gle", "Gaeilge", null, "Irish"},
                    {(ushort)182, null, "ig", "ibo", "ibo", "ibo", "ibo", "Igbo", null, "Igbo"},
                    {(ushort)183, null, "he", "heb", "heb", "heb", "heb", "עברית", null, "Hebrew"},
                    {(ushort)184, null, "zu", "zul", "zul", "zul", "zul", "isiZulu", null, "Zulu"},
                    {(ushort)165, null, "gl", "glg", "glg", "glg", "glg", "Galego", null, "Galician"},
                    {(ushort)164, null, "ff", "ful", "ful", "ful", "ful", "Fulfulde", null, "Fula"},
                    {(ushort)163, null, "fr", "fra", "fre", "fra", "fra", "Français", null, "French"},
                    {(ushort)162, null, "ik", "ipk", "ipk", "ipk", "ipk", "Iñupiak", null, "Inupiaq"},
                    {(ushort)141, null, "ja", "jpn", "jpn", "jpn", "jpn", "日本語", null, "Japanese"},
                    {(ushort)142, null, "jv", "jav", "jav", "jav", "jav", "Basa Jawa", null, "Javanese"},
                    {(ushort)143, null, "kl", "kal", "kal", "kal", "kal", "Kalaallisut", null, "Kalaallisut"},
                    {(ushort)144, null, "kn", "kan", "kan", "kan", "kan", "ಕನ್ನಡ", null, "Kannada"},
                    {(ushort)145, null, "kr", "kau", "kau", "kau", "kau", "Kanuri", null, "Kanuri"},
                    {(ushort)146, null, "ks", "kas", "kas", "kas", "kas", "كشميري", null, "Kashmiri"},
                    {(ushort)147, null, "kk", "kaz", "kaz", "kaz", "kaz", "Қазақша", null, "Kazakh"},
                    {(ushort)148, null, "km", "khm", "khm", "khm", "khm", "ភាសាខ្មែរ", null, "Khmer"},
                    {(ushort)149, null, "ki", "kik", "kik", "kik", "kik", "Gĩkũyũ", null, "Kikuyu"},
                    {(ushort)94, null, "my", "mya", "bur", "mya", "mya", "မြန်မာဘာသာ", null, "Burmese"},
                    {(ushort)150, null, "rw", "kin", "kin", "kin", "kin", "Kinyarwanda", null, "Kinyarwanda"},
                    {(ushort)152, null, "kv", "kom", "kom", "kom", "kom", "Коми", null, "Komi"},
                    {(ushort)153, null, "kg", "kon", "kon", "kon", "kon", "Kongo", null, "Kongo"},
                    {(ushort)154, null, "ko", "kor", "kor", "kor", "kor", "한국어", null, "Korean"},
                    {(ushort)155, null, "ku", "kur", "kur", "kur", "kur", "Kurdî", null, "Kurdish"},
                    {(ushort)156, null, "kj", "kua", "kua", "kua", "kua", "Kuanyama", null, "Kwanyama"},
                    {(ushort)157, null, "la", "lat", "lat", "lat", "lat", "Latina", null, "Latin"},
                    {(ushort)159, null, "it", "ita", "ita", "ita", "ita", "Italiano", null, "Italian"},
                    {(ushort)160, null, "is", "isl", "ice", "isl", "isl", "Íslenska", null, "Icelandic"},
                    {(ushort)161, null, "io", "ido", "ido", "ido", "ido", "Ido", null, "Ido"},
                    {(ushort)151, null, "ky", "kir", "kir", "kir", "kir", "Кыргызча", null, "Kyrgyz"},
                    {(ushort)93, null, "lg", "lug", "lug", "lug", "lug", "Luganda", null, "Ganda"},
                    {(ushort)158, null, "lb", "ltz", "ltz", "ltz", "ltz", "Lëtzebuergesch", null, "Luxembourgish"},
                    {(ushort)91, null, "ln", "lin", "lin", "lin", "lin", "Lingála", null, "Lingala"},
                    {(ushort)24, null, "nn", "nno", "nno", "nno", "nno", "Norsk (Nynorsk)", null, "Norwegian Nynorsk"},
                    {(ushort)25, null, "lt", "lit", "lit", "lit", "lit", "Lietuvių", null, "Lithuanian"},
                    {(ushort)26, null, "lu", "lub", "lub", "lub", "lub", "Tshiluba", null, "Luba-Katanga"},
                    {(ushort)27, null, "lv", "lav", "lav", "lav", "lav", "Latviešu", null, "Latvian"},
                    {(ushort)28, null, "gv", "glv", "glv", "glv", "glv", "Gaelg", null, "Manx"},
                    {(ushort)29, null, "mk", "mkd", "mac", "mkd", "mkd", "Македонски", null, "Macedonian"},
                    {(ushort)30, null, "mg", "mlg", "mlg", "mlg", "mlg", "Malagasy", null, "Malagasy"},
                    {(ushort)31, null, "ms", "msa", "may", "msa", "msa", "Bahasa Melayu", null, "Malay"},
                    {(ushort)32, null, "ml", "mal", "mal", "mal", "mal", "മലയാളം", null, "Malayalam"},
                    {(ushort)33, null, "mt", "mlt", "mlt", "mlt", "mlt", "Malti", null, "Maltese"},
                    {(ushort)34, null, "mi", "mri", "mao", "mri", "mri", "Māori", null, "Māori"},
                    {(ushort)35, null, "mr", "mar", "mar", "mar", "mar", "मराठी", null, "Marathi"},
                    {(ushort)36, null, "mh", "mah", "mah", "mah", "mah", "Kajin M̧ajeļ", null, "Marshallese"},
                    {(ushort)37, null, "mn", "mon", "mon", "mon", "mon", "Монгол", null, "Mongolian"},
                    {(ushort)38, null, "na", "nau", "nau", "nau", "nau", "Dorerin Naoero", null, "Nauru"},
                    {(ushort)39, null, "nv", "nav", "nav", "nav", "nav", "Diné Bizaad", null, "Navajo"},
                    {(ushort)40, null, "nd", "nde", "nde", "nde", "nde", "isiNdebele", null, "Northern Ndebele"},
                    {(ushort)42, null, "ng", "ndo", "ndo", "ndo", "ndo", "Owambo", null, "Ndonga"},
                    {(ushort)43, null, "nb", "nob", "nob", "nob", "nob", "Norsk (Bokmål)", null, "Norwegian Bokmål"},
                    {(ushort)23, null, "ii", "iii", "iii", "iii", "iii", "ꆈꌠ꒿ Nuosuhxop", null, "Nuosu"},
                    {(ushort)44, null, "no", "nor", "nor", "nor", "nor", "Norsk", null, "Norwegian"},
                    {(ushort)22, null, "sd", "snd", "snd", "snd", "snd", "سنڌي‎", null, "Sindhi"},
                    {(ushort)20, null, "sc", "srd", "srd", "srd", "srd", "Sardu", null, "Sardinian"},
                    {(ushort)92, null, "li", "lim", "lim", "lim", "lim", "Limburgs", null, "Limburgish"},
                    {(ushort)2, null, "oc", "oci", "oci", "oci", "oci", "Occitan", null, "Occitan"},
                    {(ushort)3, null, "oj", "oji", "oji", "oji", "oji", "ᐊᓂᔑᓈᐯᒧᐎᓐ", null, "Ojibwe"},
                    {(ushort)4, null, "cu", "chu", "chu", "chu", "chu", "Словѣ́ньскъ", null, "Old Church Slavonic"},
                    {(ushort)5, null, "om", "orm", "orm", "orm", "orm", "Afaan Oromoo", null, "Oromo"},
                    {(ushort)6, null, "or", "ori", "ori", "ori", "ori", "ଓଡି଼ଆ", null, "Oriya"},
                    {(ushort)7, null, "os", "oss", "oss", "oss", "oss", "Ирон æвзаг", null, "Ossetian"},
                    {(ushort)8, null, "pa", "pan", "pan", "pan", "pan", "ਪੰਜਾਬੀ", null, "Panjabi"},
                    {(ushort)9, null, "pi", "pli", "pli", "pli", "pli", "पाऴि", null, "Pāli"},
                    {(ushort)10, null, "fa", "fas", "per", "fas", "fas", "فارسی", null, "Persian"},
                    {(ushort)11, null, "pl", "pol", "pol", "pol", "pol", "Polski", null, "Polish"},
                    {(ushort)12, null, "ps", "pus", "pus", "pus", "pus", "پښتو", null, "Pashto"},
                    {(ushort)13, null, "pt", "por", "por", "por", "por", "Português", null, "Portuguese"},
                    {(ushort)14, null, "qu", "que", "que", "que", "que", "Runa Simi", null, "Quechua"},
                    {(ushort)15, null, "rm", "roh", "roh", "roh", "roh", "Rumantsch", null, "Romansh"},
                    {(ushort)16, null, "rn", "run", "run", "run", "run", "Kirundi", null, "Kirundi"},
                    {(ushort)17, null, "ro", "ron", "rum", "ron", "ron", "Română", null, "Romanian"},
                    {(ushort)18, null, "ru", "rus", "rus", "rus", "rus", "Русский", null, "Russian"},
                    {(ushort)19, null, "sa", "san", "san", "san", "san", "संस्कृतम्", null, "Sanskrit"},
                    {(ushort)21, null, "nr", "nbl", "nbl", "nbl", "nbl", "isiNdebele", null, "Southern Ndebele"},
                    {(ushort)45, null, "lo", "lao", "lao", "lao", "lao", "ພາສາລາວ", null, "Lao"},
                    {(ushort)41, null, "ne", "nep", "nep", "nep", "nep", "नेपाली", null, "Nepali"},
                    {(ushort)47, null, "sg", "sag", "sag", "sag", "sag", "Sängö", null, "Sango"},
                    {(ushort)71, null, "sr", "srp", "srp", "srp", "srp", "Српски", null, "Serbian"},
                    {(ushort)46, null, "se", "sme", "sme", "sme", "sme", "Sámegiella", null, "Northern Sami"},
                    {(ushort)73, null, "sn", "sna", "sna", "sna", "sna", "ChiShona", null, "Shona"},
                    {(ushort)74, null, "si", "sin", "sin", "sin", "sin", "සිංහල", null, "Sinhala"},
                    {(ushort)75, null, "sk", "slk", "slo", "slk", "slk", "Slovenčina", null, "Slovak"},
                    {(ushort)76, null, "sl", "slv", "slv", "slv", "slv", "Slovenščina", null, "Slovene"},
                    {(ushort)77, null, "so", "som", "som", "som", "som", "Soomaaliga", null, "Somali"},
                    {(ushort)78, null, "st", "sot", "sot", "sot", "sot", "Sesotho", null, "Southern Sotho"},
                    {(ushort)79, null, "es", "spa", "spa", "spa", "spa", "Español", null, "Spanish"},
                    {(ushort)70, null, "tk", "tuk", "tuk", "tuk", "tuk", "Türkmençe", null, "Turkmen"},
                    {(ushort)80, null, "su", "sun", "sun", "sun", "sun", "Basa Sunda", null, "Sundanese"},
                    {(ushort)82, null, "ss", "ssw", "ssw", "ssw", "ssw", "SiSwati", null, "Swati"},
                    {(ushort)83, null, "sv", "swe", "swe", "swe", "swe", "Svenska", null, "Swedish"},
                    {(ushort)84, null, "ta", "tam", "tam", "tam", "tam", "தமிழ்", null, "Tamil"},
                    {(ushort)85, null, "te", "tel", "tel", "tel", "tel", "తెలుగు", null, "Telugu"},
                    {(ushort)86, null, "tg", "tgk", "tgk", "tgk", "tgk", "Тоҷикӣ", null, "Tajik"},
                    {(ushort)87, null, "th", "tha", "tha", "tha", "tha", "ภาษาไทย", null, "Thai"},
                    {(ushort)88, null, "ti", "tir", "tir", "tir", "tir", "ትግርኛ", null, "Tigrinya"},
                    {(ushort)89, null, "bo", "bod", "tib", "bod", "bod", "བོད་ཡིག", null, "Tibetan Standard"},
                    {(ushort)90, null, "tl", "tgl", "tgl", "tgl", "tgl", "Tagalog", null, "Tagalog"},
                    {(ushort)81, null, "sw", "swa", "swa", "swa", "swa", "Kiswahili", null, "Swahili"},
                    {(ushort)69, null, "tn", "tsn", "tsn", "tsn", "tsn", "Setswana", null, "Tswana"},
                    {(ushort)72, null, "gd", "gla", "gla", "gla", "gla", "Gàidhlig", null, "Gaelic"},
                    {(ushort)67, null, "to", "ton", "ton", "ton", "ton", "faka Tonga", null, "Tonga"},
                    {(ushort)48, null, "tr", "tur", "tur", "tur", "tur", "Türkçe", null, "Turkish"},
                    {(ushort)49, null, "ts", "tso", "tso", "tso", "tso", "Xitsonga", null, "Tsonga"},
                    {(ushort)50, null, "tt", "tat", "tat", "tat", "tat", "Татарча", null, "Tatar"},
                    {(ushort)51, null, "tw", "twi", "twi", "twi", "twi", "Twi", null, "Twi"},
                    {(ushort)52, null, "ty", "tah", "tah", "tah", "tah", "Reo Mā’ohi", null, "Tahitian"},
                    {(ushort)68, null, "sm", "smo", "smo", "smo", "smo", "Gagana Sāmoa", null, "Samoan"},
                    {(ushort)54, null, "uk", "ukr", "ukr", "ukr", "ukr", "Українська", null, "Ukrainian"},
                    {(ushort)55, null, "ur", "urd", "urd", "urd", "urd", "اردو", null, "Urdu"},
                    {(ushort)56, null, "uz", "uzb", "uzb", "uzb", "uzb", "O‘zbek", null, "Uzbek"},
                    {(ushort)57, null, "ve", "ven", "ven", "ven", "ven", "Tshivenḓa", null, "Venda"},
                    {(ushort)53, null, "ug", "uig", "uig", "uig", "uig", "ئۇيغۇرچه", null, "Uyghur"},
                    {(ushort)59, null, "vo", "vol", "vol", "vol", "vol", "Volapük", null, "Volapük"},
                    {(ushort)60, null, "wa", "wln", "wln", "wln", "wln", "Walon", null, "Walloon"},
                    {(ushort)61, null, "cy", "cym", "wel", "cym", "cym", "Cymraeg", null, "Welsh"},
                    {(ushort)62, null, "wo", "wol", "wol", "wol", "wol", "Wolof", null, "Wolof"},
                    {(ushort)63, null, "fy", "fry", "fry", "fry", "fry", "Frysk", null, "Western Frisian"},
                    {(ushort)64, null, "xh", "xho", "xho", "xho", "xho", "isiXhosa", null, "Xhosa"},
                    {(ushort)65, null, "yi", "yid", "yid", "yid", "yid", "ייִדיש", null, "Yiddish"},
                    {(ushort)58, null, "vi", "vie", "vie", "vie", "vie", "Tiếng Việt", null, "Vietnamese"},
                    {(ushort)66, null, "yo", "yor", "yor", "yor", "yor", "Yorùbá", null, "Yoruba"}
                });

            migrationBuilder.InsertData(
                "licenses",
                new[]
                {
                    "Id", "CreatedDateUtc", "DescriptionUrl", "ModifiedDateUtc", "Name", "PermissiveAdaptation",
                    "PermissiveCommercial"
                },
                new object[,]
                {
                    {
                        (byte)14, null, "http://www.wtfpl.net/", null,
                        "Do What The Fuck You Want To Public License (WTFPL)", true, true
                    },
                    {
                        (byte)15, null, "https://creativecommons.org/licenses/by-nd/4.0/", null, "CC BY-ND 4.0", false,
                        true
                    },
                    {(byte)16, null, "https://creativecommons.org/licenses/by/3.0/", null, "CC BY 3.0", true, true},
                    {(byte)17, null, "https://opensource.org/licenses/ISC", null, "ISC", true, true},
                    {
                        (byte)22, null, "https://raw.githubusercontent.com/googlehosts/hosts/master/LICENSE", null,
                        "GoogleHosts", false, false
                    },
                    {
                        (byte)19, null, "https://www.gnu.org/licenses/old-licenses/gpl-2.0.html", null, "GPLv2", true,
                        true
                    },
                    {(byte)20, null, null, null, "Public Domain", true, true},
                    {
                        (byte)13, null, "https://creativecommons.org/licenses/by-nc/4.0/", null, "CC BY-NC 4.0", true,
                        false
                    },
                    {
                        (byte)23, null, "https://dbad-license.org/", null, "\"Don't Be A Dick\" Public License", true,
                        true
                    },
                    {(byte)18, null, "https://www.apache.org/licenses/LICENSE-2.0", null, "Apache 2.0", true, true},
                    {
                        (byte)12, null, "https://creativecommons.org/licenses/by-sa/3.0/", null, "CC BY-SA 3.0", true,
                        true
                    },
                    {(byte)21, null, "https://osint.bambenekconsulting.com/license.txt", null, "OSINT", true, true},
                    {(byte)10, null, "https://opensource.org/licenses/BSD-3-Clause", null, "BSD-3-Clause", true, true},
                    {(byte)11, null, "https://unlicense.org/", null, "The Unlicense", true, true},
                    {
                        (byte)1, null, "https://creativecommons.org/licenses/by-nc-nd/4.0/", null, "CC BY-NC-ND 4.0",
                        false, false
                    },
                    {(byte)3, null, null, null, "Restricted", false, false},
                    {(byte)4, null, "https://www.gnu.org/licenses/gpl-3.0.en.html", null, "GPLv3", true, true},
                    {(byte)2, null, "https://opensource.org/licenses/MIT", null, "The MIT License", true, true},
                    {
                        (byte)6, null, "https://creativecommons.org/licenses/by-nc-sa/3.0/", null, "CC BY-NC-SA 3.0",
                        true, false
                    },
                    {(byte)7, null, null, null, "Permissive", true, true},
                    {
                        (byte)8, null, "https://creativecommons.org/licenses/by-sa/4.0/", null, "CC BY-SA 4.0", true,
                        true
                    },
                    {
                        (byte)9, null, "https://creativecommons.org/licenses/by-nc-sa/4.0/", null, "CC BY-NC-SA 4.0",
                        true, false
                    },
                    {
                        (byte)5, null, "https://en.wikipedia.org/wiki/All_rights_reserved", null, "All Rights Reserved",
                        false, false
                    }
                });

            migrationBuilder.InsertData(
                "maintainers",
                new[] {"Id", "CreatedDateUtc", "EmailAddress", "HomeUrl", "ModifiedDateUtc", "Name", "TwitterHandle"},
                new object[,]
                {
                    {(ushort)46, null, null, "https://adguard.com/", null, "AdGuard", "adguard"},
                    {
                        (ushort)51, null, "lolipopplus@protonmail.com", "https://github.com/Rictusempra", null,
                        "Rictusempra", null
                    },
                    {
                        (ushort)49, null, "zerodot1@bk.ru", "https://github.com/ZeroDot1", null, "ZeroDot1",
                        "hobbygrafix"
                    },
                    {(ushort)48, null, null, "https://github.com/eladkarako", null, "Elad Karako", null},
                    {(ushort)47, null, null, "https://github.com/reek", null, "Reek", null},
                    {
                        (ushort)45, null, "support@disconnect.me", "https://disconnect.me", null, "Disconnect",
                        "disconnectme"
                    },
                    {(ushort)40, null, null, "https://warui.intaa.net/", null, "Warui", "gatolabo"},
                    {(ushort)43, null, null, "https://github.com/Lerist", null, "Lerist", null},
                    {(ushort)42, null, null, "http://cosmonote.blogspot.jp", null, "Cosmonote", null},
                    {
                        (ushort)41, null, null, "https://github.com/multiverse2011", null, "Multiverse2011",
                        "multiverse2011_"
                    },
                    {(ushort)52, null, null, "https://github.com/tomasko126", null, "Tomáš Taro", null},
                    {
                        (ushort)39, null, "me@pureapp.in.th", "https://www.pureapp.in.th/", null,
                        "Pakkapon Phongthawee", null
                    },
                    {(ushort)38, null, null, "https://klout.com/kowith337", null, "kowith337", "kowith337"},
                    {(ushort)44, null, null, "http://vxvault.net/", null, "VXVault", null},
                    {(ushort)53, null, null, "https://github.com/Hubird-au", null, "Hubird-au", null},
                    {(ushort)58, null, null, "https://github.com/toshiya44", null, "toshiya44", null},
                    {(ushort)55, null, null, "https://github.com/haykam821", null, "haykam821", null},
                    {
                        (ushort)71, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=9300", null,
                        "invisible666", null
                    },
                    {(ushort)70, null, null, "https://github.com/KonoromiHimaries", null, "KonoromiHimaries", null},
                    {(ushort)69, null, null, "https://github.com/notracking", null, "notracking", null},
                    {(ushort)68, null, null, "https://github.com/betterwebleon/", null, "betterwebleon", null},
                    {
                        (ushort)67, null, "joewein@pobox.com", "https://www.joewein.net/spam/index.htm", null,
                        "Joe Wein", null
                    },
                    {(ushort)66, null, null, "https://gist.github.com/BBcan177", null, "BBcan177", null},
                    {(ushort)64, null, null, null, null, "Frellwit", null},
                    {
                        (ushort)63, null, null, "https://jspenguin2017.github.io/uBlockProtector/", null,
                        "Jspenguin2017", null
                    },
                    {(ushort)62, null, null, "https://github.com/raghavdua1995", null, "Raghav Dua", null},
                    {
                        (ushort)61, null, "CHEF-KOCH@protonmail.com", "https://github.com/CHEF-KOCH", null, "CHEF-KOCH",
                        "CKsTechNews"
                    },
                    {(ushort)60, null, "hajdar@tutanota.com", null, null, "hajdar", null},
                    {
                        (ushort)59, null, "jamie@jamiedubs.com", "http://tramchase.com/", null, "Jamie Wilkinson",
                        "jamiew"
                    },
                    {(ushort)37, null, null, "https://github.com/vokins", null, "vokins", null},
                    {(ushort)57, null, null, "https://github.com/gorhill", null, "Raymond Hill", null},
                    {(ushort)56, null, null, "https://github.com/cb-software", null, "cb-software", null},
                    {(ushort)54, null, null, "https://github.com/hl2guide", null, "deanoman", null},
                    {(ushort)36, null, null, "https://github.com/monojp", null, "Monojp", null},
                    {
                        (ushort)50, null, "webmaster@squidblacklist.org", "https://www.squidblacklist.org/", null,
                        "Squid Blacklist", null
                    },
                    {
                        (ushort)34, null, "PolishJarvis@gmail.com", "https://github.com/PolishFiltersTeam/", null,
                        "Polish Filters Team", null
                    },
                    {(ushort)14, null, null, "https://www.fanboy.co.nz/", null, "fanboy", null},
                    {
                        (ushort)13, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=1260", null,
                        "smed79", null
                    },
                    {
                        (ushort)12, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=2266", null,
                        "Crits", null
                    },
                    {
                        (ushort)11, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=542", null,
                        "Lian", null
                    },
                    {
                        (ushort)10, null, null, "https://www.malwaredomainlist.com/", null,
                        "Malware Domain List Community", "_MDL_"
                    },
                    {(ushort)9, null, "admin@oxeankoret.com", "http://joxeankoret.com/", null, "Joxean Koret", null},
                    {
                        (ushort)16, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=1488", null,
                        "Famlam", null
                    },
                    {(ushort)8, null, null, "https://github.com/mayve", null, "mayve", null},
                    {(ushort)6, null, "info@eyeo.com", "https://eyeo.com/", null, "eyeo GmbH", "eyeo"},
                    {(ushort)5, null, null, "https://www.michaeltrimm.com/", null, "Michael Trimm", null},
                    {
                        (ushort)4, null, null, "https://forum.xda-developers.com/member.php?u=4877037", null,
                        "BSDgeek_Jake", null
                    },
                    {(ushort)3, null, null, "https://bradconte.com/", null, "Brad Conte", "bradconte"},
                    {(ushort)2, null, null, null, null, "AppliliZ", null},
                    {(ushort)35, null, "bjorn@bjornstar.com", "https://bjornstar.com/", null, "Bjorn Stromberg", null},
                    {(ushort)7, null, null, "https://easylist.to/", null, "The EasyList Authors", null},
                    {
                        (ushort)17, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=1400", null,
                        "Khrin", null
                    },
                    {
                        (ushort)15, null, null, "https://forums.lanik.us/memberlist.php?mode=viewprofile&u=333", null,
                        "MonztA", null
                    },
                    {
                        (ushort)19, null, null, "https://www.blogger.com/profile/09662737599549871224", null,
                        "MVPS HOSTS Maintainer", null
                    },
                    {(ushort)33, null, null, "https://github.com/azet12/", null, "azet12", null},
                    {(ushort)32, null, null, "https://github.com/MajkiIT", null, "MajkiIT", null},
                    {(ushort)31, null, null, "https://github.com/arcetera", null, "arcetera", null},
                    {(ushort)30, null, "anudeep@protonmail.com", "https://github.com/anudeepND", null, "Anudeep", null},
                    {(ushort)29, null, null, "https://github.com/bkrucarci", null, "bkrucarci", null},
                    {(ushort)18, null, null, "https://github.com/SlowMemory", null, "SlowMemory", null},
                    {(ushort)27, null, null, "https://ker.af/", null, "Rafael K", "iamkeraf"},
                    {(ushort)28, null, null, "https://github.com/maciejtarmas", null, "Maciej Tarmas", null},
                    {
                        (ushort)25, null, "badmojr@gmail.com", "https://forum.xda-developers.com/member.php?u=8758244",
                        null, "badmojr", null
                    },
                    {(ushort)24, null, null, "https://github.com/metaphoricgiraffe", null, "metaphoricgiraffe", null},
                    {(ushort)23, null, "contactme@abuse.ch", "https://abuse.ch/", null, "abuse.ch", "abuse_ch"},
                    {
                        (ushort)22, null, "imreeil42@gmail.com", "https://sproutsluckycorner.wordpress.com/", null,
                        "Imre Kristoffer Eilertsen", null
                    },
                    {(ushort)21, null, null, "https://github.com/hoshsadiq/adblock-nocoin-list", null, "Hosh", null},
                    {(ushort)20, null, null, "https://github.com/taylr", null, "Matt Taylor", null},
                    {(ushort)26, null, null, "https://github.com/elypter", null, "elypter", null}
                });

            migrationBuilder.InsertData(
                "software",
                new[] {"Id", "CreatedDateUtc", "DownloadUrl", "HomeUrl", "ModifiedDateUtc", "Name"},
                new object[,]
                {
                    {
                        (byte)12, null, "https://github.com/2ndalpha/gasmask/releases",
                        "https://github.com/2ndalpha/gasmask", null, "Gas Mask"
                    },
                    {
                        (byte)11, null, "https://github.com/scottlerch/HostsFileEditor/releases",
                        "https://scottlerch.github.io/HostsFileEditor/", null, "Hosts File Editor"
                    },
                    {
                        (byte)10, null, "http://einaregilsson.com/redirector/", "http://einaregilsson.com/redirector/",
                        null, "Redirector"
                    },
                    {
                        (byte)8, null,
                        "https://chrome.google.com/webstore/detail/personal-blocklist-by-goo/nolijncfnkgaikbjbdaogikpmpbdcdef",
                        "https://chrome.google.com/webstore/detail/personal-blocklist-by-goo/nolijncfnkgaikbjbdaogikpmpbdcdef",
                        null, "Personal Blocklist (Chrome)"
                    },
                    {
                        (byte)9, null, "https://addons.mozilla.org/firefox/addon/personal-blocklist/",
                        "https://github.com/wildskyf/personal-blocklist", null, "Personal Blocklist (Firefox)"
                    },
                    {(byte)7, null, "https://f-droid.org/packages/org.adaway/", "https://adaway.org/", null, "AdAway"},
                    {(byte)3, null, "https://adguard.com/en/download.html", "https://adguard.com/", null, "AdGuard"},
                    {
                        (byte)5, null, "https://github.com/NanoAdblocker/NanoCore#nano-adblocker-core",
                        "https://github.com/NanoAdblocker/NanoCore", null, "Nano Adblocker"
                    },
                    {
                        (byte)4, null, "https://f-droid.org/packages/org.jak_linux.dns66/",
                        "https://github.com/julian-klode/dns66", null, "DNS66"
                    },
                    {(byte)2, null, "https://adblockplus.org/", "https://adblockplus.org/", null, "Adblock Plus"},
                    {
                        (byte)1, null, "https://github.com/gorhill/uBlock#installation",
                        "https://github.com/gorhill/uBlock", null, "uBlock Origin"
                    },
                    {(byte)6, null, "https://getadblock.com/", "https://getadblock.com/", null, "AdBlock"}
                });

            migrationBuilder.InsertData(
                "syntaxes",
                new[] {"Id", "CreatedDateUtc", "DefinitionUrl", "ModifiedDateUtc", "Name"},
                new object[,]
                {
                    {
                        (byte)12, null, "https://github.com/NanoAdblocker/NanoCore/tree/master/notes", null,
                        "Nano Adblocker Static"
                    },
                    {(byte)11, null, null, null, "JavaScript (Non-Safari)"},
                    {
                        (byte)10, null,
                        "https://blogs.msdn.microsoft.com/ie/2010/12/07/ie9-and-privacy-introducing-tracking-protection/",
                        null, "Tracking Protection List (IE)"
                    },
                    {(byte)9, null, null, null, "IPs"},
                    {
                        (byte)7, null, "https://github.com/gorhill/uBlock/wiki/Dynamic-filtering:-quick-guide", null,
                        "uBlock Origin/uMatrix Dynamic"
                    },
                    {(byte)8, null, null, null, "URLs"},
                    {
                        (byte)4, null, "https://github.com/gorhill/uBlock/wiki/Static-filter-syntax", null,
                        "uBlock Origin Static"
                    },
                    {
                        (byte)3, null, "https://adblockplus.org/filters", null,
                        "Adblock Plus (Latest/Unspecified Version)"
                    },
                    {(byte)2, null, null, null, "Domains"},
                    {(byte)1, null, "https://en.wikipedia.org/wiki/Hosts_(file)", null, "Hosts"},
                    {
                        (byte)6, null, "https://kb.adguard.com/en/general/how-to-create-your-own-ad-filters", null,
                        "AdGuard"
                    }
                });

            migrationBuilder.InsertData(
                "tags",
                new[] {"Id", "CreatedDateUtc", "Description", "ModifiedDateUtc", "Name"},
                new object[,]
                {
                    {(byte)10, null, "Unblocks categorical resources", null, "whitelist"},
                    {(byte)15, null, "Blocks specific topics/things", null, "topical"},
                    {(byte)14, null, "Intended for research only", null, "research"},
                    {(byte)13, null, "Extends or blocks functionality from search engines", null, "search"},
                    {(byte)12, null, "Redirects traffic through proxies to get around firewalls", null, "proxy"},
                    {(byte)11, null, "Blocks adult, NSFW, pornographic, etc. resources", null, "nsfw"},
                    {(byte)9, null, "Blocks subjectively annoying resources", null, "annoyances"},
                    {(byte)1, null, "Blocks cryptomining and/or cryptojacking", null, "crypto"},
                    {(byte)7, null, "Blocks phishing and/or scam resources", null, "phishing"},
                    {(byte)6, null, "Blocks malicious resources", null, "malware"},
                    {(byte)5, null, "Blocks adblock detection scripts", null, "anti-adblock"},
                    {(byte)4, null, "Blocks social media scripts, trackers, widgets, etc.", null, "social"},
                    {(byte)3, null, "Blocks trackers and other privacy-invasive resources", null, "privacy"},
                    {(byte)2, null, "Blocks advertisements", null, "ads"},
                    {(byte)16, null, "Removes obstructing or annoying overlays", null, "overlay"},
                    {
                        (byte)8, null, "Blocks cookie notices primarily in response to the EU Cookie Law", null,
                        "cookies"
                    },
                    {(byte)17, null, "Intended for use with Internet Explorer's TPL feature", null, "ie"}
                });

            migrationBuilder.InsertData(
                "filterlists",
                new[]
                {
                    "Id", "CantSnapshot", "ChatUrl", "CreatedDateUtc", "Description", "DescriptionSourceUrl",
                    "DiscontinuedDate", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId",
                    "ModifiedDateUtc", "Name", "PolicyUrl", "PublishedDate", "SubmissionUrl", "SyntaxId", "ViewUrl"
                },
                new object[,]
                {
                    {
                        (ushort)481, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Ad Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedAd/energized/hosts"
                    },
                    {
                        (ushort)233, false, null, null, "Block only sidebar annoyances.",
                        "https://facebook.adblockplus.me/", null, "https://adblockplus.org/en/donate",
                        "subscriptionlist@adblockplus.org", null, "https://facebook.adblockplus.me/", null, (byte)5,
                        null, "Facebook Sidebar Blocker", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/fb_annoyances_sidebar.txt"
                    },
                    {
                        (ushort)229, false, null, null, "Block only comments.", "https://youtube.adblockplus.me/", null,
                        "https://adblockplus.org/en/donate", "subscriptionlist@adblockplus.org", null,
                        "https://youtube.adblockplus.me/", null, (byte)5, null, "YouTube: Remove Comments", null, null,
                        null, (byte)3, "https://easylist-downloads.adblockplus.org/yt_annoyances_comments.txt"
                    },
                    {
                        (ushort)227, false, null, null, "Allow non-intrusive advertising.",
                        "https://easylist-downloads.adblockplus.org/exceptionrules.txt", null, null, "info@eyeo.com",
                        null, "https://acceptableads.com/", null, (byte)5, null, "Acceptable Ads", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/exceptionrules.txt"
                    },
                    {
                        (ushort)224, false, "https://discord.me/polskiefiltry", null,
                        "Filters that hide and block messages about cookies and GDPR/privacy policy on Polish websites.",
                        null, null, "https://patronite.pl/polskiefiltry", null, null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null,
                        "Polish GDPR-Cookies Filters", null,
                        new DateTime(2017, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/cookies_filters/adblock_cookies.txt"
                    },
                    {
                        (ushort)223, false, "https://discord.me/polskiefiltry", null,
                        "Presented here filter set was created for Polish internet users. Contains a list of elements of advertising, such as banners or flash animations, the most commonly used on Polish websites.",
                        "https://www.certyficate.it/polski-filtr-adblock/", null, "https://patronite.pl/polskiefiltry",
                        "errors@certyficate.it", null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null,
                        "Official Polish Filters for AdBlock, uBlock Origin & AdGuard", null,
                        new DateTime(2018, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/polish-adblock-filters/adblock.txt"
                    },
                    {
                        (ushort)216, false, "https://discord.me/polskiefiltry", null,
                        "Filters that hide and block social network elements, i.e. widgets, pop-ups and other social elements on Polish websites.",
                        null, null, "https://patronite.pl/polskiefiltry", null, null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null, "Polish Social Filters",
                        null, new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/adblock_social_filters/adblock_social_list.txt"
                    },
                    {
                        (ushort)214, false, null, null,
                        "The Adblock Warning Removal List specifically removes obtrusive messages and warnings targeted to users who use an adblocker.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylist.subscription+anti@gmail.com", "https://forums.lanik.us/",
                        "https://easylist.to/", null, (byte)5, null, "Adblock Warning Removal List", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/antiadblockfilters.txt"
                    },
                    {
                        (ushort)207, false, null, null,
                        "Helps you keep your Ad-Blocker active, when you visit a website and it asks you to disable. Composed of a user script «AakScript» written in javascript and a filter list «AakList» using the same syntax as lists AdBlock and AdBlock Plus, the two are complementary and unlock different website.",
                        "https://github.com/reek/anti-adblock-killer/blob/master/README.md",
                        new DateTime(2016, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://github.com/reek/anti-adblock-killer/#donate", null, null,
                        "https://github.com/reek/anti-adblock-killer/",
                        "https://github.com/reek/anti-adblock-killer/issues", (byte)8, null,
                        "AakList (Anti-Adblock Killer)", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/reek/anti-adblock-killer/master/anti-adblock-killer-filters.txt"
                    },
                    {
                        (ushort)197, false, null, null, "A list combining ABPindo and EasyList.", null, null, null,
                        null, null, null, null, (byte)5, null, "ABPindo + EasyList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/abpindo+easylist.txt"
                    },
                    {
                        (ushort)184, false, null, null, "Blocks Facebook trackers.", null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW", null,
                        null, "https://fanboy.co.nz/", null, (byte)5, null, "Anti-Facebook List", null, null, null,
                        (byte)3, "https://fanboy.co.nz/fanboy-antifacebook.txt"
                    },
                    {
                        (ushort)170, false, null, null, "Blocks ads injected by adware.",
                        "https://adblockplus.org/subscriptions", null, null, "easylist.subscription@gmail.com",
                        "https://forums.lanik.us/", "https://easylist.to/", null, (byte)5, null, "Adware Filters", null,
                        null, null, (byte)3, "https://easylist-downloads.adblockplus.org/adwarefilters.txt"
                    },
                    {
                        (ushort)150, false, null, null,
                        "Blocks most popular internet statistics counters on sites serving Russia.", null, null, null,
                        null, "https://forums.lanik.us/viewforum.php?f=102",
                        "https://code.google.com/archive/p/ruadlist/", null, (byte)5, null, "RU AdList: Counters", null,
                        null, null, (byte)3, "https://easylist-downloads.adblockplus.org/cntblock.txt"
                    },
                    {
                        (ushort)134, false, null, null, "Russian-only fork of Fanboy's Annoyance List.", null, null,
                        null, null, "https://forums.lanik.us/viewforum.php?f=102",
                        "https://code.google.com/archive/p/ruadlist/", null, (byte)5, null, "RU AdList: BitBlock", null,
                        null, null, (byte)3, "https://easylist-downloads.adblockplus.org/bitblock.txt"
                    },
                    {
                        (ushort)133, false, null, null, "A list combining RU AdList and EasyList.", null, null, null,
                        null, null, null, null, (byte)5, null, "RU AdList + EasyList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/ruadlist+easylist.txt"
                    },
                    {
                        (ushort)131, false, null, null, "Russian supplement for EasyList.",
                        "https://adblockplus.org/subscriptions", null, null, null,
                        "https://forums.lanik.us/viewforum.php?f=102", "https://code.google.com/archive/p/ruadlist/",
                        null, (byte)5, null, "RU AdList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/advblock.txt"
                    },
                    {
                        (ushort)117, false, null, null, "A list combining ROList and EasyList.", null, null, null, null,
                        null, null, null, (byte)5, null, "ROList + EasyList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/rolist+easylist.txt"
                    },
                    {
                        (ushort)98, false, null, null, "Block only other annoyances.",
                        "https://youtube.adblockplus.me/", null, "https://adblockplus.org/en/donate",
                        "subscriptionlist@adblockplus.org", null, "https://youtube.adblockplus.me/", null, (byte)5,
                        null, "YouTube: Other Annoyances", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/yt_annoyances_other.txt"
                    },
                    {
                        (ushort)97, false, null, null, "Block all YouTube annoyances.",
                        "https://youtube.adblockplus.me/", null, "https://adblockplus.org/en/donate",
                        "subscriptionlist@adblockplus.org", null, "https://youtube.adblockplus.me/", null, (byte)5,
                        null, "YouTube: Pure Video Experience", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/yt_annoyances_full.txt"
                    },
                    {
                        (ushort)94, false, null, null,
                        "You can leave AdBlock functioning as normal, but the proper tracking of cashback cookies will be allowed on TopCashback and our affiliate network sites only.",
                        "https://www.topcashback.com/Help/164", null, null, null, null,
                        "https://www.topcashback.com/Help/164", null, (byte)5, null, "Top Cash Back Adblock Whitelist",
                        null, null, null, (byte)3, "https://www.topcashback.com/Misc/AdBlockWhiteList.aspx"
                    },
                    {
                        (ushort)61, false, null, null,
                        "A Polish filter that protects against scams such as SMS subscriptions.",
                        "https://github.com/azet12/KAD", null, null, "kadrep@outlook.com", null,
                        "https://azet12.github.io/KAD/", "https://github.com/azet12/KAD/issues", (byte)8, null,
                        "KAD - Scams", null, null, "https://azet12.github.io/KAD/informacje.html#form1-35", (byte)3,
                        "https://raw.githubusercontent.com/azet12/KAD/master/KAD.txt"
                    },
                    {
                        (ushort)56, false, null, null, "A list combining Latvian List and EasyList.", null, null, null,
                        null, null, null, null, (byte)5, null, "Latvian List + EasyList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/latvianlist+easylist.txt"
                    },
                    {
                        (ushort)30, false, "https://discord.me/polskiefiltry", null,
                        "Filters that hide and block pop-ups, widgets, newsletters, push notifications, arrows and other irritating elements on Polish websites (include Polish GDPR-Cookies Filters).",
                        "https://github.com/PolishFiltersTeam/PolishAnnoyanceFilters", null, null, null, null,
                        "https://polishannoyancefilters.netlify.com",
                        "https://github.com/PolishFiltersTeam/PolishAnnoyanceFilters/issues", (byte)9, null,
                        "Polish Annoyance Filters", null,
                        new DateTime(2016, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://polishannoyancefilters.netlify.com/issues", (byte)3,
                        "https://raw.githubusercontent.com/PolishFiltersTeam/PolishAnnoyanceFilters/master/PPB.txt"
                    },
                    {
                        (ushort)20, false, null, null,
                        "Removes ads, affiliation ads, and empty boxes on Norwegian sites to produce a cleaner browser experience. Meant to be used on top of general filters.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Norwegian Filters for Tidier Websites", null, null, null, (byte)3,
                        "https://github.com/DandelionSprout/adfilt/raw/master/NorwegianList.txt"
                    },
                    {
                        (ushort)19, false, null, null,
                        "A list for uBlock/Adblock plus to stop cryptomining in your browser. ",
                        "https://github.com/hoshsadiq/adblock-nocoin-list", null, null, null, null,
                        "https://github.com/hoshsadiq/adblock-nocoin-list",
                        "https://github.com/hoshsadiq/adblock-nocoin-list/issues", (byte)2, null, "NoCoin", null, null,
                        null, (byte)3,
                        "https://raw.githubusercontent.com/hoshsadiq/adblock-nocoin-list/master/nocoin.txt"
                    },
                    {
                        (ushort)18, false, null, null,
                        "Remove filler, upsells, click bait and other low or negative-value annoyances.",
                        "https://github.com/taylr/linkedinsanity", null, null, null, null,
                        "https://github.com/taylr/linkedinsanity", "https://github.com/taylr/linkedinsanity/issues",
                        (byte)2, null, "Linked Insanity Annoyance Rules", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/taylr/linkedinsanity/master/linkedinsanity.txt"
                    },
                    {
                        (ushort)14, false, null, null,
                        "Liste AR is an EasyList affiliated filter list that specifically removes adverts on Arabic language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "liste.ar.adblock@gmail.com", "https://forums.lanik.us/viewforum.php?f=98",
                        "https://code.google.com/archive/p/liste-ar-adblock/", null, (byte)6, null, "Liste AR", null,
                        null, null, (byte)3, "https://easylist-downloads.adblockplus.org/Liste_AR.txt"
                    },
                    {
                        (ushort)13, false, null, null, "A merged list of Liste AR, Liste FR, and EasyList", null, null,
                        null, null, null, null, null, (byte)6, null, "Liste AR + Liste FR + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/liste_ar+liste_fr+easylist.txt"
                    },
                    {
                        (ushort)235, false, null, null, "Block only news feed annoyances.",
                        "https://facebook.adblockplus.me/", null, "https://adblockplus.org/en/donate",
                        "subscriptionlist@adblockplus.org", null, "https://facebook.adblockplus.me/", null, (byte)5,
                        null, "Facebook News Feed Annoyances Blocker", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/fb_annoyances_newsfeed.txt"
                    },
                    {
                        (ushort)12, false, null, null,
                        "Liste FR is an EasyList affiliated filter list that specifically removes adverts on French language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "listefr.adblock@gmail.com", "https://forums.lanik.us/viewforum.php?f=91",
                        "https://forums.lanik.us/viewforum.php?f=91", null, (byte)6, null, "Liste FR", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/liste_fr.txt"
                    },
                    {
                        (ushort)236, false, null, null, "Block all Facebook annoyances.",
                        "https://facebook.adblockplus.me/", null, "https://adblockplus.org/en/donate",
                        "subscriptionlist@adblockplus.org", null, "https://facebook.adblockplus.me/", null, (byte)5,
                        null, "Facebook Annoyances Blocker", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/fb_annoyances_full.txt"
                    },
                    {
                        (ushort)240, false, null, null,
                        "This EasyPrivacy variant does not contain rules for international domains.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylist.subscription@gmail.com", "https://forums.lanik.us/", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null,
                        "EasyPrivacy Without International Filters", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easyprivacy_nointernational.txt"
                    },
                    {
                        (ushort)292, false, null, null, "A list combining EasyList Germany and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "EasyList Germany + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/easylistgermany+easylist.txt"
                    },
                    {
                        (ushort)290, false, null, null, "A list combining EasyList Hebrew and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "EasyList Hebrew + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/israellist+easylist.txt"
                    },
                    {
                        (ushort)289, false, null, null,
                        "EasyList Italy is a filter list written by the EasyList author Khrin that specifically removes adverts on Italian language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylistitaly@gmail.com", "https://forums.lanik.us/viewforum.php?f=96",
                        "https://easylist.to/", null, (byte)5, null, "EasyList Italy", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylistitaly.txt"
                    },
                    {
                        (ushort)283, false, null, null, "A list combining Bulgarian List and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "Bulgarian List + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/bulgarian_list+easylist.txt"
                    },
                    {
                        (ushort)271, false, null, null,
                        "This is a list of malware domains generated from malwaredomains.com data.",
                        "https://easylist-downloads.adblockplus.org/malwaredomains_full.txt", null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null,
                        "DNS-BH Adblock Plus Malware Domains Full", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/malwaredomains_full.txt"
                    },
                    {
                        (ushort)269, false, null, null, "A list combining EasyList Italy and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "EasyList Italy + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/easylistitaly+easylist.txt"
                    },
                    {
                        (ushort)266, false, null, null,
                        "A list combining EasyList, EasyPrivacy, and Fanboy's Enhanced Tracking List.", null, null,
                        null, null, null, null, null, (byte)5, null, "Fanboy's Complete List", null, null, null,
                        (byte)3, "https://fanboy.co.nz/r/fanboy-complete.txt"
                    },
                    {
                        (ushort)265, false, null, null,
                        "Blocks common tracking scripts such as Omniture, Webtrends, Foresee, Coremetrics, Google-Analytics, Touchclarity, ChannelIntelligence.",
                        "https://fanboy.co.nz/filters.html", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW", null,
                        null, "https://fanboy.co.nz/", "https://github.com/easylist/easylist/issues", (byte)5, null,
                        "Fanboy's Enhanced Tracking List", null, null, null, (byte)3,
                        "https://fanboy.co.nz/enhancedstats.txt"
                    },
                    {
                        (ushort)264, false, null, null, "Blocks Indian regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Indian", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-indian.txt"
                    },
                    {
                        (ushort)263, false, null, null, "Blocks Hebrew regional advertisements and trackers.", null,
                        new DateTime(2013, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null,
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's IsraelList", null, null, null, (byte)3,
                        "https://fanboy.co.nz/israelilist/IsraelList.txt"
                    },
                    {
                        (ushort)262, false, null, null, "Blocks Japanese regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Japanese", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-japanese.txt"
                    },
                    {
                        (ushort)261, false, null, null, "Blocks Korean regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Korean", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-korean.txt"
                    },
                    {
                        (ushort)260, false, null, null, "Blocks Polish regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Polish", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-polish.txt"
                    },
                    {
                        (ushort)259, false, null, null,
                        "Hide and block social content, social widgets, social scripts and social icons.",
                        "https://fanboy.co.nz/", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "easylist.subscription@gmail.com", "https://forums.lanik.us/", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null, "Fanboy's Social Blocking List",
                        null, null, null, (byte)3, "https://easylist-downloads.adblockplus.org/fanboy-social.txt"
                    },
                    {
                        (ushort)258, false, null, null,
                        "Blocks Spanish and Portuguese regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Spanish/Portuguese", null, null, null, (byte)3,
                        "https://fanboy.co.nz/fanboy-espanol.txt"
                    },
                    {
                        (ushort)257, false, null, null, "Blocks Swedish regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Swedish", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-swedish.txt"
                    },
                    {
                        (ushort)256, false, null, null, "Blocks Turkish regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Turkish", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-turkish.txt"
                    },
                    {
                        (ushort)255, false, null, null,
                        "A list combining EasyList, EasyPrivacy, Fanboy's Enhanced Tracking List, and Fanboy's Annoyance List.",
                        null, null, null, null, null, null, null, (byte)5, null, "Fanboy's Ultimate List", null, null,
                        null, (byte)3, "https://fanboy.co.nz/r/fanboy-ultimate.txt"
                    },
                    {
                        (ushort)254, false, null, null, "Blocks Vietnamese regional advertisements and trackers.", null,
                        new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "fanboyadblock@googlegroups.com", null, "https://fanboy.co.nz/", null, (byte)5, null,
                        "Fanboy's Vietnamese", null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-vietnam.txt"
                    },
                    {
                        (ushort)250, false, null, null, "This will remove cookie and privacy warnings.",
                        "https://fanboy.co.nz/", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "easylist.subscription@gmail.com", "https://forums.lanik.us/", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null, "Fanboy's Cookiemonster List",
                        null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-cookiemonster.txt"
                    },
                    {
                        (ushort)249, false, null, null, "Blocks fonts loaded from third parties.", null, null, null,
                        null, null, "https://fanboy.co.nz/", null, (byte)5, null, "Fanboy's Anti-thirdparty Fonts",
                        null, null, null, (byte)3, "https://fanboy.co.nz/fanboy-antifonts.txt"
                    },
                    {
                        (ushort)248, false, null, null, "A list combining EasyList Lithuania and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "EasyList Lithuania + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/easylistlithuania+easylist.txt"
                    },
                    {
                        (ushort)247, false, null, null,
                        "In page Pop-Ups and other annoyances; thereby substantially decreasing web page loading times and uncluttering them (includes Fanboy's Social Blocking List and Fanboy's Cookiemonster List.)",
                        "https://fanboy.co.nz/", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW",
                        "easylist.subscription@gmail.com", "https://forums.lanik.us/", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null, "Fanboy's Annoyance List", null,
                        null, null, (byte)3, "https://easylist-downloads.adblockplus.org/fanboy-annoyance.txt"
                    },
                    {
                        (ushort)246, false, null, null, "Spanish supplement for EasyList.",
                        "https://adblockplus.org/subscriptions", null, null, "easylist.spanish@gmail.com",
                        "https://forums.lanik.us/viewforum.php?f=103", "https://easylist.to/", null, (byte)5, null,
                        "EasyList Spanish", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylistspanish.txt"
                    },
                    {
                        (ushort)244, false, null, null,
                        "This EasyList variant only contains blocking filters to remove adverts, with no element rules whatsoever; it, therefore, has more limited coverage than the full version of the list, although still commands a niche market.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylist.subscription@gmail.com", "https://forums.lanik.us/viewforum.php?f=23",
                        "https://easylist.to/", "https://github.com/easylist/easylist/issues", (byte)5, null,
                        "EasyList Without Element Hiding Rules", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylist_noelemhide.txt"
                    },
                    {
                        (ushort)243, false, null, null,
                        "This EasyList variant does not contain filters for adult domains.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylist.subscription@gmail.com", "https://forums.lanik.us/viewforum.php?f=23",
                        "https://easylist.to/", "https://github.com/easylist/easylist/issues", (byte)5, null,
                        "EasyList Without Rules for Adult Sites", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylist_noadult.txt"
                    },
                    {
                        (ushort)241, false, null, null, "A list combining EasyPrivacy and EasyList.", null, null, null,
                        null, null, null, null, (byte)5, null, "EasyPrivacy + EasyList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easyprivacy+easylist.txt"
                    },
                    {
                        (ushort)239, false, null, null,
                        "Testing unsafe rules for EasyList that will break certain websites.",
                        "https://easylist-downloads.adblockplus.org/easytest.txt", null, null, null,
                        "https://forums.lanik.us/viewtopic.php?t=8505", "https://forums.lanik.us/viewtopic.php?t=8505",
                        null, (byte)5, null, "EasyTest", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easytest.txt"
                    },
                    {
                        (ushort)11, false, null, null, "A merged list of Liste FR and EasyList", null, null, null, null,
                        null, null, null, (byte)6, null, "Liste FR + EasyList", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/liste_fr+easylist.txt"
                    },
                    {
                        (ushort)9, false, null, null,
                        "A full set of Malware URLs to be used by security researchers and anti-malware researchers. It can also be used by individuals to protect themselves.",
                        "http://malwareurls.joxeankoret.com/",
                        new DateTime(2015, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "info@joxeankoret.com",
                        null, "http://malwareurls.joxeankoret.com/", null, (byte)2, null, "Malware URLs", null, null,
                        null, (byte)3, "http://malwareurls.joxeankoret.com/normal.txt"
                    },
                    {
                        (ushort)7, false, null, null,
                        "The Malware URLs in the 'gray area.' To be used by security researchers and anti-malware researchers. It can also be used by individuals to protect themselves. The 'gray area' is an area where many malware URLs exists, but there is also a big number of false positives as the gray area is the one where only 2 or 3 pieces of evidence were discovered. The 'gray area' should not be used for blocking domains or URLs, it is published only with the aim of helping malware researchers.",
                        "http://malwareurls.joxeankoret.com/",
                        new DateTime(2015, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "info@joxeankoret.com",
                        null, "http://malwareurls.joxeankoret.com/", null, (byte)2, null, "Malware URLs Gray Area",
                        null, null, null, (byte)3, "http://malwareurls.joxeankoret.com/grayarea.txt"
                    },
                    {
                        (ushort)412, false, null, null, null, null, null, null, null, null,
                        "https://gist.github.com/BBcan177", null, (byte)5, null, "pfBlockerNG - MS-3", null, null, null,
                        (byte)2,
                        "https://gist.githubusercontent.com/BBcan177/d7105c242f17f4498f81/raw/201968fa11b1f409d408a129a0774ffedb1560e2/MS-3"
                    },
                    {
                        (ushort)411, false, null, null, null, "", null, null, null, null,
                        "https://gist.github.com/BBcan177", null, (byte)18, null,
                        "pfBlockerNG - Blacklist Configuration", null, null, null, (byte)2,
                        "https://gist.githubusercontent.com/BBcan177/b91d3c25667d326411b6fc4eb5c1f080/raw/7e23b07148adf030262f056870373c8f1ac2056c/squidblacklist_global_usage"
                    },
                    {
                        (ushort)400, false, null, null,
                        "Blocks ads, fake sites, shock sites, malware hosts and trackers. This hostfile's aim is not to break any useful websites.",
                        null, null, null, null, null, "https://github.com/notracking/hosts-blocklists",
                        "https://github.com/notracking/hosts-blocklists/issues", (byte)5, null, "notracking - Domains",
                        null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/notracking/hosts-blocklists/master/domains.txt"
                    },
                    {
                        (ushort)395, false, null, null,
                        "This is a whitelist for DNSlock & PiHole which unblocks some of the popular domains which were wrongly listed and blocked by hosts file from various sources.",
                        null, null, null, null, null, "https://github.com/raghavdua1995/DNSlock-PiHole-whitelist",
                        "https://github.com/raghavdua1995/DNSlock-PiHole-whitelist/issues", (byte)7, null,
                        "DNSlock-PiHole-whitelist", null,
                        new DateTime(2018, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)2,
                        "https://raw.githubusercontent.com/raghavdua1995/DNSlock-PiHole-whitelist/master/whitelist.list"
                    },
                    {
                        (ushort)366, false, null, null, "Malicious, hijacked, ransomware, dangerous websites",
                        "https://www.squidblacklist.org/downloads.html", null, null, "webmaster@squidblacklist.org",
                        null, "https://www.squidblacklist.org/", null, (byte)15, null, "Squid Blacklist Malicious",
                        null, null, "https://www.squidblacklist.org/php/url_submission_form.php", (byte)2,
                        "https://www.squidblacklist.org/downloads/dg-malicious.acl"
                    },
                    {
                        (ushort)365, false, null, null, "Official Facebook domains",
                        "https://www.squidblacklist.org/downloads.html", null, null, "webmaster@squidblacklist.org",
                        null, "https://www.squidblacklist.org/", null, (byte)15, null, "Squid Blacklist Facebook", null,
                        null, "https://www.squidblacklist.org/php/url_submission_form.php", (byte)2,
                        "https://www.squidblacklist.org/downloads/dg-facebook.acl"
                    },
                    {
                        (ushort)364, false, null, null, "Advertisements and tracking",
                        "https://www.squidblacklist.org/downloads.html", null, null, "webmaster@squidblacklist.org",
                        null, "https://www.squidblacklist.org/", null, (byte)15, null,
                        "Squid Blacklist Ad Servers and Trackers", null, null,
                        "https://www.squidblacklist.org/php/url_submission_form.php", (byte)2,
                        "https://www.squidblacklist.org/downloads/dg-ads.acl"
                    },
                    {
                        (ushort)359, false, null, null, "A list to prevent browser mining only",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null,
                        "CoinBlocker Domains List Browser", null,
                        new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)2,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/list_browser.txt"
                    },
                    {
                        (ushort)358, false, null, null, "An additional list for administrators",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null,
                        "CoinBlocker Domains List Optional", null,
                        new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)2,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/list_optional.txt"
                    },
                    {
                        (ushort)357, false, null, null, "A list for administrators to prevent mining in networks",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null,
                        "CoinBlocker Domains List", null,
                        new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)2,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/list.txt"
                    },
                    {
                        (ushort)333, false, null, null,
                        "LeeCh's web list for filtering out search results for certain anime sites.",
                        "https://github.com/pureexe/LeeCh-List/blob/master/README.md", null, null, null, null,
                        "https://github.com/pureexe/LeeCh-List", "https://github.com/pureexe/LeeCh-List/issues",
                        (byte)2, null, "LeeCh List", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/pureexe/LeeCh-List/master/anime.txt"
                    },
                    {
                        (ushort)326, false, null, null, "Hostfiles for adblocking / privacy reasons.",
                        "https://github.com/monojp/hosts_merge/blob/master/README.md", null, null, null, null,
                        "https://github.com/monojp/hosts_merge", "https://github.com/monojp/hosts_merge/issues",
                        (byte)5, null, "Monojp's Hosts", null, null, null, (byte)2,
                        "https://hosts.herndl.org/hosts_blacklist.txt"
                    },
                    {
                        (ushort)323, false, null, null,
                        "This file contain domains that are needed to be whitelisted depending on the service you use. (It may include analytics sites!)",
                        "https://github.com/anudeepND/whitelist/blob/master/README.md", null, null,
                        "anudeep@protonmail.com", null, "https://github.com/anudeepND/whitelist",
                        "https://github.com/anudeepND/whitelist/issues", (byte)2, null,
                        "Commonly Whitelisted Domains (Optional)", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/anudeepND/whitelist/master/domains/optional-list.txt"
                    },
                    {
                        (ushort)322, false, null, null,
                        "Some deals sites like Slickdeals and Fatwallet needs a few sites (most of them are ads) to be whitelisted to work properly.",
                        "https://github.com/anudeepND/whitelist/blob/master/README.md", null, null,
                        "anudeep@protonmail.com", null, "https://github.com/anudeepND/whitelist",
                        "https://github.com/anudeepND/whitelist/issues", (byte)2, null,
                        "Commonly Whitelisted Domains (Referral Sites)", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/anudeepND/whitelist/master/domains/referral-sites.txt"
                    },
                    {
                        (ushort)321, false, null, null, "Commonly whitelisted domains for Pi-Hole.",
                        "https://github.com/anudeepND/whitelist/blob/master/README.md", null, null,
                        "anudeep@protonmail.com", null, "https://github.com/anudeepND/whitelist",
                        "https://github.com/anudeepND/whitelist/issues", (byte)2, null, "Commonly Whitelisted Domains",
                        null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/anudeepND/whitelist/master/domains/whitelist.txt"
                    },
                    {
                        (ushort)319, false, null, null,
                        "An expiremental list of domains for blocking YouTube video ads.", null, null, null,
                        "anudeep@protonmail.com", null, "https://github.com/anudeepND/youtubeadsblacklist",
                        "https://github.com/anudeepND/youtubeadsblacklist/issues", (byte)14, null,
                        "YouTube Video Ads Blocklist Domains", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/anudeepND/youtubeadsblacklist/master/domainlist.txt"
                    },
                    {
                        (ushort)310, false, null, null, "A small supplement list for 1Hosts.", null, null, null,
                        "badmojr@gmail.com",
                        "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360",
                        "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360",
                        null, (byte)5, null, "1Hosts Addon", null, null, null, (byte)2, "https://1hosts.cf/addon/"
                    },
                    {
                        (ushort)275, false, null, null, "Blocks advertisements.", null, null, null,
                        "support@disconnect.me", null, "https://disconnect.me/trackerprotection", null, (byte)4, null,
                        "Disconnect Advertising Filter List", null, null, null, (byte)2,
                        "https://s3.amazonaws.com/lists.disconnect.me/simple_ad.txt"
                    },
                    {
                        (ushort)274, false, null, null, "Blocks malvertising.", null, null, null,
                        "support@disconnect.me", null, "https://disconnect.me/trackerprotection", null, (byte)4, null,
                        "Disconnect Malvertising Filter List", null, null, null, (byte)2,
                        "https://s3.amazonaws.com/lists.disconnect.me/simple_malvertising.txt"
                    },
                    {
                        (ushort)273, false, null, null, "Blocks malware.", null, null, null, "support@disconnect.me",
                        null, "https://disconnect.me/trackerprotection", null, (byte)4, null,
                        "Disconnect Malware Filter List", null, null, null, (byte)2,
                        "https://s3.amazonaws.com/lists.disconnect.me/simple_malware.txt"
                    },
                    {
                        (ushort)272, false, null, null, "Blocks trackers.", null, null, null, "support@disconnect.me",
                        null, "https://disconnect.me/trackerprotection", null, (byte)4, null,
                        "Disconnect Tracking Filter List", null, null, null, (byte)2,
                        "https://s3.amazonaws.com/lists.disconnect.me/simple_tracking.txt"
                    },
                    {
                        (ushort)129, false, null, null,
                        "Blocks TeslaCrypt from botnet command and control servers by domain.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker TeslaCrypt Ransomware C2 Domain Blocklist", null, null, null, (byte)2,
                        "https://ransomwaretracker.abuse.ch/downloads/TC_C2_DOMBL.txt"
                    },
                    {
                        (ushort)126, false, null, null, "Blocks TeslaCrypt from payment site servers by domain.", null,
                        null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null,
                        (byte)7, null, "Ransomware Tracker TeslaCrypt Ransomware Payment Sites Domain Blocklist", null,
                        null, null, (byte)2, "https://ransomwaretracker.abuse.ch/downloads/TC_PS_DOMBL.txt"
                    },
                    {
                        (ushort)124, false, null, null,
                        "Blocks TorrentLocker from botnet command and control servers by domain.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker TorrentLocker Ransomware C2 Domain Blocklist", null, null, null, (byte)2,
                        "https://ransomwaretracker.abuse.ch/downloads/TL_C2_DOMBL.txt"
                    },
                    {
                        (ushort)397, false, null, null, null, null, null, null, null, null,
                        "https://jspenguin2017.github.io/uBlockProtector/",
                        "https://jspenguin2017.github.io/uBlockProtector/issues", (byte)4, null,
                        "Nano filters - Whitelist", null, null, null, (byte)12,
                        "https://cdn.rawgit.com/NanoAdblocker/NanoFilters/master/NanoFilters/NanoWhitelist.txt"
                    },
                    {
                        (ushort)77, false, null, null, "Blocks Locky from payment site servers by domain.", null, null,
                        null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7,
                        null, "Ransomware Tracker Locky Ransomware Payment Sites Domain Blocklist", null, null, null,
                        (byte)2, "https://ransomwaretracker.abuse.ch/downloads/LY_PS_DOMBL.txt"
                    },
                    {
                        (ushort)37, false, null, null,
                        "Blocks Locky from botnet command and control servers by domain.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker Locky Ransomware C2 Domain Blocklist", null, null, null, (byte)2,
                        "https://ransomwaretracker.abuse.ch/downloads/LY_C2_DOMBL.txt"
                    },
                    {
                        (ushort)413, false, null, null,
                        "The following is the list of sites from Alexa top 1 million which embed scripts that extract email addresses from the browsers' built-in login (password) managers.",
                        null, null, null, null, null, "https://gist.github.com/BBcan177", null, (byte)5, null,
                        "pfBlockerNG - MS-4", null, null, null, (byte)2,
                        "https://gist.githubusercontent.com/BBcan177/b6df57cef74e28d90acf1eec93d62d3b/raw/f0996cf5248657ada2adb396f3636be8716b99eb/MS-4"
                    },
                    {
                        (ushort)414, false, null, null, null, null, null, null, null, null,
                        "https://gist.github.com/BBcan177", null, (byte)5, null, "pfBlockerNG - MS-2", null, null, null,
                        (byte)2,
                        "https://gist.githubusercontent.com/BBcan177/4a8bf37c131be4803cb2/raw/343ff780e15205b4dd0de37c86af34cfb26b2fbe/MS-2"
                    },
                    {
                        (ushort)415, false, null, null, null, null, null, null, null, null,
                        "https://gist.github.com/BBcan177", null, (byte)5, null, "pfBlockerNG - MS-1", null, null, null,
                        (byte)2,
                        "https://gist.githubusercontent.com/BBcan177/bf29d47ea04391cb3eb0/raw/7290e0681bcd07415420b5c80a253652fd13f840/MS-1"
                    },
                    {
                        (ushort)416, false, null, null, null, null, null, null, null, null,
                        "https://gist.github.com/BBcan177", null, (byte)5, null, "EasyList DE Domains", null, null,
                        null, (byte)2,
                        "https://gist.githubusercontent.com/BBcan177/2a9fc2548c3c5a5e2dc86e580b5795d2/raw/2f5c90ffb3bd02199ace1b16a0bd9f53b29f0879/EasyList_DE"
                    },
                    {
                        (ushort)6, false, null, null,
                        "A filter list that blocks advertisements and trackers on Japanese properties", null, null,
                        null, null, null, "https://github.com/mayve/private-adblock-filters",
                        "https://github.com/mayve/private-adblock-filters/issues", (byte)5, null,
                        "Private Adblock Filters", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/mayve/private-adblock-filters/master/Adblock_List.txt"
                    },
                    {
                        (ushort)5, false, null, null,
                        "A list to keep people from knowing you have read their Facebook message",
                        "https://adblockplus.org/blog/how-to-keep-people-from-knowing-you-ve-read-their-facebook-message",
                        null, "https://adblockplus.org/en/donate", null, "https://adblockplus.org/forum/index.php",
                        "https://adblockplus.org/blog/how-to-keep-people-from-knowing-you-ve-read-their-facebook-message",
                        null, (byte)4, null, "Message \"Seen\" Remover for Facebook", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/message_seen_remover_for_facebook.txt"
                    },
                    {
                        (ushort)2, false, null, null,
                        "Mute is an AdBlock Plus filter for user comments. In the same way that AdBlock hides ads, AdBlock can use this filter to hide user-generated comments, allowing you to browse the Internet with less stupidity clawing at your eyeballs.",
                        "https://mute.bradconte.com/", null, null, null, null, "https://mute.bradconte.com/",
                        "https://github.com/B-Con/mute/issues", (byte)2, null, "Mute", null, null, null, (byte)3,
                        "https://mute.bradconte.com/mute.txt"
                    },
                    {
                        (ushort)1, false, null, null,
                        "A filter list that blocks mobile advertisements and trackers on Japanese properties", null,
                        null, null, null, null, "https://280blocker.net", null, (byte)1, null, "280 Blocker", null,
                        null,
                        "https://docs.google.com/forms/d/e/1FAIpQLScNeZhFrFZt9GhIVGdThGz7oyepcNRKuOi5PJDnsC-awxTeOQ/viewform",
                        (byte)3, "https://280blocker.net/files/280blocker_adblock.txt"
                    },
                    {
                        (ushort)465, false, null, null, null, null, null, null, null, null, null, null, (byte)2, null,
                        "Shalla Malware", null, null, null, (byte)2, "https://v.firebog.net/hosts/Shalla-mal.txt"
                    },
                    {
                        (ushort)464, false, null, null, null, null, null, null, null, null, null, null, (byte)2, null,
                        "Prigent Tracking", null, null, null, (byte)2,
                        "https://v.firebog.net/hosts/Prigent-Tracking.txt"
                    },
                    {
                        (ushort)463, false, null, null, null, null, null, null, null, null, null, null, (byte)2, null,
                        "Prigent Malware", null, null, null, (byte)2, "https://v.firebog.net/hosts/Prigent-Malware.txt"
                    },
                    {
                        (ushort)448, false, null, null, "Malware Domains Block List from quidsup.net", null, null,
                        "https://quidsup.net/donate/", null, null, "https://quidsup.net/notrack/blocklist.php",
                        "https://gitlab.com/quidsup/notrack-blocklists/issues", (byte)4, null,
                        "NoTrack Malware Blocklist", null, null, null, (byte)2,
                        "https://gitlab.com/quidsup/notrack-blocklists/raw/master/notrack-malware.txt"
                    },
                    {
                        (ushort)447, false, null, null, "Tracker Domains Block List from quidsup.net", null, null,
                        "https://quidsup.net/donate/", null, null, "https://quidsup.net/notrack/blocklist.php",
                        "https://gitlab.com/quidsup/notrack-blocklists/issues", (byte)4, null,
                        "NoTrack Tracker Blocklist", null, null, null, (byte)2,
                        "https://gitlab.com/quidsup/notrack-blocklists/raw/master/notrack-blocklist.txt"
                    },
                    {
                        (ushort)446, false, null, null, null, null, null, null, null, null, null, null, (byte)2, null,
                        "Prigent Ads", null, null, null, (byte)2, "https://v.firebog.net/hosts/Prigent-Ads.txt"
                    },
                    {
                        (ushort)445, false, null, null, null, null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=HU4EDJZP2S9QA", null,
                        null, "https://firebog.net/", null, (byte)2, null, "EasyPrivacy Hosts", null, null, null,
                        (byte)2, "https://v.firebog.net/hosts/Easyprivacy.txt"
                    },
                    {
                        (ushort)444, false, null, null, null, null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=HU4EDJZP2S9QA", null,
                        null, "https://firebog.net/", null, (byte)2, null, "EasyList Hosts", null, null, null, (byte)2,
                        "https://v.firebog.net/hosts/Easylist.txt"
                    },
                    {
                        (ushort)443, false, null, null, null, null, null, null, null, null, null, null, (byte)2, null,
                        "Kowabit", null, null, null, (byte)2, "https://v.firebog.net/hosts/Kowabit.txt"
                    },
                    {
                        (ushort)293, false, null, null,
                        "EasyList Germany is a filter list written by the EasyList authors MonztA, Famlam, and Khrin that specifically removes adverts on German language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylist.germany@gmail.com", "https://forums.lanik.us/viewforum.php?f=90",
                        "https://easylist.to/", "https://github.com/easylist/easylistgermany/issues", (byte)5, null,
                        "EasyList Germany", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylistgermany.txt"
                    },
                    {
                        (ushort)442, false, null, null, null, null, null, null, null, null, null, null, (byte)2, null,
                        "Bill Stearns' Hosts", null, null, null, (byte)2, "https://v.firebog.net/hosts/BillStearns.txt"
                    },
                    {
                        (ushort)440, false, null, null, null, null, null, null, "mail@perflyst.de", null,
                        "https://github.com/Perflyst/PiHoleBlocklist",
                        "https://github.com/Perflyst/PiHoleBlocklist/issues", (byte)2, null,
                        "PiHole Blocklist Android Tracking", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/Perflyst/PiHoleBlocklist/master/android-tracking.txt"
                    },
                    {
                        (ushort)439, false, null, null, null, null, null, null, "mail@perflyst.de", null,
                        "https://github.com/Perflyst/PiHoleBlocklist",
                        "https://github.com/Perflyst/PiHoleBlocklist/issues", (byte)2, null, "PiHole Blocklist SmartTV",
                        null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/Perflyst/PiHoleBlocklist/master/SmartTV.txt"
                    },
                    {
                        (ushort)438, false, null, null, null, null, null, null, "mail@perflyst.de", null,
                        "https://github.com/Perflyst/PiHoleBlocklist",
                        "https://github.com/Perflyst/PiHoleBlocklist/issues", (byte)2, null,
                        "PiHole Blocklist Session Replay", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/Perflyst/PiHoleBlocklist/master/SessionReplay.txt"
                    },
                    {
                        (ushort)428, false, null, null, null, null, null, null, null, null,
                        "https://www.threatcrowd.org/", null, (byte)5, null, "ThreatCrowd Domains", null, null, null,
                        (byte)2, "https://www.threatcrowd.org/feeds/domains.txt"
                    },
                    {
                        (ushort)427, false, null, null,
                        "The phishing bad sites is updated using data from www.phishtank.com once per day. The domains included are known to be fraudulent and generally dangerous.",
                        null, null, null, null, null, "http://phishing.mailscanner.info/", null, (byte)5, null,
                        "Phishing Bad Sites", null, null, null, (byte)2,
                        "http://phishing.mailscanner.info/phishing.bad.sites.conf"
                    },
                    {
                        (ushort)426, false, null, null,
                        "Master Feed of known, active and non-sinkholed C&Cs IP addresses", null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=YMFSMT9MW2Y6Q", null,
                        null, "https://osint.bambenekconsulting.com/feeds/", null, (byte)21, null, "OSINT C2 IP Feed",
                        null, null, null, (byte)2, "https://osint.bambenekconsulting.com/feeds/c2-ipmasterlist.txt"
                    },
                    {
                        (ushort)425, false, null, null,
                        "Self-updating PHP library which blocks hundreds of spammy domains from ruining your website statistics",
                        "https://github.com/nabble/semalt-blocker#self-updating-php-library-which-blocks-hundreds-of-spammy-domains-from-ruining-your-website-statistics",
                        null, null, null, null, "https://github.com/nabble/semalt-blocker",
                        "https://github.com/nabble/semalt-blocker/issues", (byte)2, null, "Semalt Blocked Domains",
                        null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/nabble/semalt-blocker/master/domains/blocked"
                    },
                    {
                        (ushort)424, false, null, null, null, null, null, null, null, null,
                        "https://gist.github.com/MOxFIVE", null, (byte)5, null, "Personal Blocklist (MOxFIVE)", null,
                        null, null, (byte)2,
                        "https://gist.githubusercontent.com/MOxFIVE/4730cac715ef406bd8eac7b29335be4a/raw/d21fa08e97963edde372d0d3e50703c783c9c32e/Personal%2520Blocklist.txt"
                    },
                    {
                        (ushort)422, false, null, null,
                        "List of shit websites for Google Personal Blocklist or Google Hit Hider by Domain",
                        "https://github.com/ligyxy/Blocklist#blocklist", null, null, null, null,
                        "https://github.com/ligyxy/Blocklist", "https://github.com/ligyxy/Blocklist/issues", (byte)2,
                        null, "Blocklist (ligyxy)", null, null, null, (byte)2,
                        "https://github.com/ligyxy/Blocklist/blob/master/BLOCKLIST"
                    },
                    {
                        (ushort)420, false, null, null, null, null, null, "https://www.joewein.net/spam/blacklist.htm",
                        null, null, "https://www.joewein.net/spam/index.htm", null, (byte)5, null,
                        "JoeWein Email Sender Blacklist", null, null, null, (byte)2,
                        "https://www.joewein.net/dl/bl/from-bl.txt"
                    },
                    {
                        (ushort)419, false, null, null,
                        "Spammers get paid by businesses whose websites they advertise. We refuse to accept spam from any of following domains or advertising any of these domains, as we don't want to buy from spammers. We publish this list for informational purposes only.",
                        "https://www.joewein.net/spam/blacklist.htm", null,
                        "https://www.joewein.net/spam/blacklist.htm", null, null,
                        "https://www.joewein.net/spam/index.htm", null, (byte)5, null, "JoeWein Domain Blacklist Base",
                        null, null, null, (byte)2, "https://www.joewein.net/dl/bl/dom-bl-base.txt"
                    },
                    {
                        (ushort)418, false, null, null, null,
                        "https://github.com/desbma/referer-spam-domains-blacklist#referer-spam-blacklist", null, null,
                        null, null, "https://github.com/desbma/referer-spam-domains-blacklist",
                        "https://github.com/desbma/referer-spam-domains-blacklist/issues", (byte)14, null,
                        "Referer Spam Blacklist (desbma)", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/desbma/referer-spam-domains-blacklist/master/spammers.txt"
                    },
                    {
                        (ushort)417, false, null, null,
                        "This is a community-contributed list of referrer spammers maintained by Matomo, the leading open source web analytics platform.",
                        null, null, null, null, null, "https://github.com/matomo-org/referrer-spam-blacklist",
                        "https://github.com/matomo-org/referrer-spam-blacklist/issues", (byte)20, null,
                        "Referrer Spam Blacklist (Matomo)", null, null, null, (byte)2,
                        "https://raw.githubusercontent.com/matomo-org/referrer-spam-blacklist/master/spammers.txt"
                    },
                    {
                        (ushort)441, false, null, null,
                        "Personal Blocklist by WaLLy3K (https://firebog.net/about).  Content added to this list has been manually verified, and usually updated every two weeks.",
                        null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=HU4EDJZP2S9QA", null,
                        null, "https://firebog.net/", null, (byte)13, null, "WaLLy3K Blocklist", null, null, null,
                        (byte)2, "https://v.firebog.net/hosts/static/w3kbl.txt"
                    },
                    {
                        (ushort)294, false, null, null, "A list combining EasyList Dutch and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "EasyList Dutch + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/easylistdutch+easylist.txt"
                    },
                    {
                        (ushort)295, false, null, null,
                        "EasyList Dutch is an [EasyList] affiliated filter list written by the EasyList author Famlam that specifically removes adverts on Dutch language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "fam.lam@live.nl", "https://forums.lanik.us/viewforum.php?f=100", "https://easylist.to/",
                        null, (byte)5, null, "EasyList Dutch", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylistdutch.txt"
                    },
                    {
                        (ushort)297, false, null, null, "A list combining EasyList Czech and Slovak and EasyList.",
                        null, null, null, null, null, null, null, (byte)5, null, "EasyList Czech and Slovak + EasyList",
                        null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylistczechslovak+easylist.txt"
                    },
                    {
                        (ushort)163, false, null, null,
                        "Filter that enables removing of the ads from websites in Japanese.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#japanese-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Japanese Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null,
                        null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/7.txt"
                    },
                    {
                        (ushort)162, false, null, null,
                        "Filter that blocks ads on mobile devices. Contains all known mobile ad networks.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#mobile-ads-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Mobile Ads Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null,
                        null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/11.txt"
                    },
                    {
                        (ushort)161, false, null, null,
                        "Filter that enables removing of the ads from websites in Russian. The filter was created 5 years ago. Initially, the work on creation of this filter was based on RU AdList filter and a set of rules developed by us. Subsequently, the filter was developed completely independently, so at this point there are very little intersections with RU AdList left.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#russian-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Russian Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null, null,
                        (byte)6, "https://filters.adtidy.org/extension/chromium/filters/1.txt"
                    },
                    {
                        (ushort)160, false, null, null,
                        "Filter that blocks ads on iOS mobile devices in Safari browser. Contains all known mobile ad networks.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#safari-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null, "AdGuard Safari Filter",
                        "https://kb.adguard.com/en/general/adguard-filter-policy", null, null, (byte)6,
                        "https://filters.adtidy.org/extension/chromium/filters/12.txt"
                    },
                    {
                        (ushort)159, false, null, null,
                        "If you do not like numerous «Like» and «Tweet» buttons on all the popular websites on the Internet, subscribe to this filter, and you will not see them anymore.",
                        "https://adguard.com/en/filters.html", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Social Media Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null,
                        null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/4.txt"
                    },
                    {
                        (ushort)158, false, null, null,
                        "Filter that enables removing of the ads from websites in Spanish.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#spanish-portuguese-filter", null, null,
                        null, "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Spanish/Portuguese Filter", "https://kb.adguard.com/en/general/adguard-filter-policy",
                        null, null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/9.txt"
                    },
                    {
                        (ushort)157, false, null, null,
                        "The most comprehensive list of various online counters and web analytics tools. If you do not want your actions on the Internet be tracked, use this filter.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#spyware-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Spyware Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null, null,
                        (byte)6, "https://filters.adtidy.org/extension/chromium/filters/3.txt"
                    },
                    {
                        (ushort)156, false, null, null,
                        "Filter that enables removing of the ads from websites with Turkish content.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#turkish-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Turkish Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null, null,
                        (byte)6, "https://filters.adtidy.org/extension/chromium/filters/13.txt"
                    }
                });

            migrationBuilder.InsertData(
                "filterlists",
                new[]
                {
                    "Id", "CantSnapshot", "ChatUrl", "CreatedDateUtc", "Description", "DescriptionSourceUrl",
                    "DiscontinuedDate", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId",
                    "ModifiedDateUtc", "Name", "PolicyUrl", "PublishedDate", "SubmissionUrl", "SyntaxId", "ViewUrl"
                },
                new object[,]
                {
                    {
                        (ushort)155, false, null, null, "Filter that unblocks ads that may be useful to users.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#filter-for-useful-ads", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Useful Ads Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null,
                        null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/10.txt"
                    },
                    {
                        (ushort)16, false, null, null,
                        "A filter list that enables removing of ads, trackers, and various scripts from websites with Korean content.",
                        "https://raw.githubusercontent.com/SlowMemory/List-KR/master/filter.txt", null, null, null,
                        null, "https://list-kr.github.io/", "https://github.com/SlowMemory/List-KR/issues", (byte)8,
                        null, "List-KR", null, null, "https://list-kr.github.io/form.html", (byte)6,
                        "https://raw.githubusercontent.com/SlowMemory/List-KR/master/filter.txt"
                    },
                    {
                        (ushort)480, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://github.com/yecarrillo/adblock-colombia",
                        "https://github.com/yecarrillo/adblock-colombia/issues", (byte)3, null,
                        "yecarrillo's ad-blocking subscription for Colombian sites", null, null, null, (byte)4,
                        "https://github.com/yecarrillo/adblock-colombia/raw/master/adblock_co.txt"
                    },
                    {
                        (ushort)436, false, null, null,
                        "A filter for uBlock Origin (Firefox Android) that aims to specifically target websites that nags people to install their app.",
                        "https://github.com/lassekongo83/Frellwits-filter-lists#available-lists", null, null, null,
                        null, "https://github.com/lassekongo83/Frellwits-filter-lists",
                        "https://github.com/lassekongo83/Frellwits-filter-lists/issues", (byte)4, null,
                        "I Don't Want Your App", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/lassekongo83/Frellwits-filter-lists/master/i-dont-want-your-app.txt"
                    },
                    {
                        (ushort)433, false, null, null,
                        "Are you tired of being told by others what you should watch, specifically the hipsters that run around on IMDB? Here's a way to let you feel more peaceful with your truly own opinions.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null, "Anti-IMDB List", null,
                        null, null, (byte)4,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Anti-IMDB%20List.txt"
                    },
                    {
                        (ushort)431, false, null, null,
                        "Have you ever felt bothered by how many websites still think that everyone are using narrow monitors? Well, here's how to stretch them out like a piece of gum!",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Website Stretcher", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Dandelion%20Sprout's%20Website%20Stretcher.txt"
                    },
                    {
                        (ushort)410, false, null, null,
                        "To foil sites potentially abusing CPU/bandwidth resources without informed consent. Any such resource-abuse scripts MUST be opt-in, with complete informed consent from the visitor.",
                        "https://github.com/uBlockOrigin/uAssets/blob/master/filters/resource-abuse.txt", null, null,
                        null, null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)4, null, "uAssets Resource Abuse", null,
                        null, null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/resource-abuse.txt"
                    },
                    {
                        (ushort)405, false, null, null,
                        "Filters optimized for uBlock Origin, to be used with Fanboy's and/or Adguard's 'Annoyances' list(s)",
                        "https://github.com/uBlockOrigin/uAssets/blob/master/filters/annoyances.txt", null, null, null,
                        null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)4, null, "uAssets Annoyances", null,
                        null, null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/annoyances.txt"
                    },
                    {
                        (ushort)399, false, null, null,
                        "A filter for uBlock Origin that aims to remove regional Swedish ads, tracking, annoyances, scams + badware, and unnecessary bloat.",
                        "https://github.com/lassekongo83/Frellwits-filter-lists#available-lists", null, null, null,
                        null, "https://github.com/lassekongo83/Frellwits-filter-lists",
                        "https://github.com/lassekongo83/Frellwits-filter-lists/issues", (byte)4, null,
                        "Frellwit's Swedish Filter", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/lassekongo83/Frellwits-filter-lists/master/Frellwits-Swedish-Filter.txt"
                    },
                    {
                        (ushort)383, false, "https://discord.gg/013MqTM1p1qm52VcZ", null,
                        "Removes uncovered AD, AD frames, and adblock warnings from specific popular websites",
                        "https://austinhuang.me/0131-block-list", null, "https://austinhuang.me/donate",
                        "im@austinhuang.me", null, "https://austinhuang.me/0131-block-list",
                        "https://github.com/austinhuang0131/0131-block-list/issues", (byte)8, null, "0131 Block List",
                        null, new DateTime(2018, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://austinhuang.me/contact", (byte)4, "https://austinhuang.me/0131-block-list/list.txt"
                    },
                    {
                        (ushort)382, false, null, null,
                        "Blocks ads/popups/fake thumbs/spam bookmark buttons and more from porn websites",
                        "https://raw.githubusercontent.com/WowDude/PornList/master/PornList.txt", null, null, null,
                        null, "https://github.com/WowDude/PornList", "https://github.com/WowDude/PornList/issues",
                        (byte)16, null, "PornList", null,
                        new DateTime(2018, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)4,
                        "https://raw.githubusercontent.com/WowDude/PornList/master/PornList.txt"
                    },
                    {
                        (ushort)380, false, null, null, "Very experimental custom filters",
                        "https://github.com/toshiya44/myAssets/blob/master/README.md", null, null, null, null,
                        "https://github.com/toshiya44/myAssets", "https://github.com/toshiya44/myAssets/issues",
                        (byte)4, null, "Toshiya's Filter List - Experimental", null,
                        new DateTime(2016, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)4,
                        "https://raw.githubusercontent.com/toshiya44/myAssets/master/filters-exp.txt"
                    },
                    {
                        (ushort)379, false, null, null,
                        "These filters will cause a button labeled: \"Disqus blocked by uBlock Origin: click to unblock\" to be embedded where Disqus comments would normally be loaded. Click the button to force the comments to be loaded.",
                        "https://gist.github.com/gorhill/ef1b62d606473c68d524", null, null, null, null,
                        "https://gist.github.com/gorhill/ef1b62d606473c68d524", null, (byte)5, null,
                        "Disqus Click-to-Load", null, new DateTime(2016, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null, (byte)4,
                        "https://gist.github.com/gorhill/ef1b62d606473c68d524/raw/f8181faac18cb5172c7c9bca8e5a3b22f0c925d0/gistfile1.txt"
                    },
                    {
                        (ushort)369, false, null, null,
                        "Official filter list file used for blocking ads on Czech and Slovak websites.",
                        "https://github.com/tomasko126/easylistczechandslovak", null, null, "tomastaro@adblock.sk",
                        "https://easylist-czech-and-slovak.tenderapp.com/", "https://adblock.sk/",
                        "https://github.com/tomasko126/easylistczechandslovak/issues", (byte)8, null,
                        "EasyList Czech and Slovak - uBlock", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/tomasko126/easylistczechandslovak/master/filters_ublock.txt"
                    },
                    {
                        (ushort)343, false, "https://discord.me/polskiefiltry", null,
                        "uBlock Origin & AdGuard supplement list for Polish GDPR-Cookies Filters.", null, null,
                        "https://patronite.pl/polskiefiltry", null, null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null,
                        "Polish GDPR-Cookies Filters - Supplement for uBlock & AdGuard", null,
                        new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)4,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/cookies_filters/cookies_uB_AG.txt"
                    },
                    {
                        (ushort)341, false, "https://discord.me/polskiefiltry", null,
                        "uBlock Origin & AdGuard supplement list for Polish Social Filters", null, null,
                        "https://patronite.pl/polskiefiltry", null, null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null,
                        "Polish Social Filters - Supplement for uBlock & AdGuard", null,
                        new DateTime(2018, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)4,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/adblock_social_filters/social_filters_uB_AG.txt"
                    },
                    {
                        (ushort)331, false, null, null,
                        "Block ads, tracking, popup sites and servers that most used on Thai sites.",
                        "https://kowith337.github.io/ThaiParanoidBlock/", null, null, null, null,
                        "https://kowith337.github.io/ThaiParanoidBlock/",
                        "https://github.com/kowith337/ThaiParanoidBlock/issues", (byte)13, null, "Thai Paranoid Block",
                        null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/kowith337/ThaiParanoidBlock/master/ThaiParanoid.txt"
                    },
                    {
                        (ushort)328, false, null, null,
                        "This list includes uBO-specific versions of filters, and are meant to be accessed by uBlock Origin, Nano Adblocker and AdGuard whenever they load the main Norwegian list.",
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExtensionsForUBO%26Nano.txt",
                        null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Norwegian Extensions For UBO & Nano", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExtensionsForUBO%26Nano.txt"
                    },
                    {
                        (ushort)313, false, null, null, "A generic list that makes annoying sticky headers unsticky.",
                        "https://raw.githubusercontent.com/elypter/filter_processor/master/generated_filterlists/blockhead(decoy_generic_selection).txt",
                        null, null, null, null, "https://github.com/elypter/filter_processor",
                        "https://github.com/elypter/filter_processor/issues", (byte)4, null,
                        "Generic Annoying Stickybar Filter v2", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/elypter/filter_processor/master/generated_filterlists/blockhead(decoy_generic_selection).txt"
                    },
                    {
                        (ushort)164, false, null, null,
                        "Filter that enables removing of the ads from websites with German content.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#german-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null, "AdGuard German Filter",
                        "https://kb.adguard.com/en/general/adguard-filter-policy", null, null, (byte)6,
                        "https://filters.adtidy.org/extension/chromium/filters/6.txt"
                    },
                    {
                        (ushort)165, false, null, null,
                        "Filter designed to test certain hazardous filtering rules before they are added to the basic filters.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#experimental-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Experimental Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null,
                        null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/5.txt"
                    },
                    {
                        (ushort)166, false, null, null,
                        "Filter that enables removing of the ads from websites with English content.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#english-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard English Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null, null,
                        (byte)6, "https://filters.adtidy.org/extension/chromium/filters/2.txt"
                    },
                    {
                        (ushort)167, false, null, null,
                        "Filter that enables removing of the ads from websites with Dutch content.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#dutch-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null, "AdGuard Dutch Filter",
                        "https://kb.adguard.com/en/general/adguard-filter-policy", null, null, (byte)6,
                        "https://filters.adtidy.org/extension/chromium/filters/8.txt"
                    },
                    {
                        (ushort)396, false, null, null, null, null, null, null, null, null,
                        "https://jspenguin2017.github.io/uBlockProtector/",
                        "https://jspenguin2017.github.io/uBlockProtector/issues", (byte)4, null, "Nano filters", null,
                        null, null, (byte)12,
                        "https://cdn.rawgit.com/NanoAdblocker/NanoFilters/master/NanoFilters/NanoBase.txt"
                    },
                    {
                        (ushort)393, false, null, null,
                        "A list that demonstrates and makes use of Einar Egilsson's Redirector extensions, in order to accomplish things that no adblock tool could've achieved. Examples include turning 32-bit Windows program installation links into 64-bit ones, making Disney's US websites accessible from other countries, and turning mobile Wikipedia links into desktop ones, among other things.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null,
                        "https://github.com/DandelionSprout/adfilt/tree/master/Dandelion%20Sprout-s%20Redirector%20Assistant%20List",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Redirector List", null,
                        new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)11,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Dandelion%20Sprout-s%20Redirector%20Assistant%20List/DandelionSproutRedirectorList.json"
                    },
                    {
                        (ushort)388, false, null, null,
                        "Removes ads, affiliation ads, and empty boxes on Norwegian sites to produce a cleaner browser experience. Meant to be used on top of general filters. The quality of the current TPL conversion is so-so, so don't expect perfect results.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Norwegian Filters for Tidier Websites (Internet Explorer)", null, null,
                        null, (byte)10,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList%20alternate%20versions/DandelionSproutsNorskeFiltre.tpl"
                    },
                    {
                        (ushort)370, false, null, null,
                        "Official filter list file used for blocking ads on Czech and Slovak websites.",
                        "https://github.com/tomasko126/easylistczechandslovak", null, null, "tomastaro@adblock.sk",
                        "https://easylist-czech-and-slovak.tenderapp.com/", "https://adblock.sk/",
                        "https://github.com/tomasko126/easylistczechandslovak/issues", (byte)8, null,
                        "EasyList Czech and Slovak - IE", null, null, null, (byte)10,
                        "https://raw.githubusercontent.com/tomasko126/easylistczechandslovak/master/filters_ie.tpl"
                    },
                    {
                        (ushort)363, false, null, null,
                        "A additional list for administrators to prevent mining in networks",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null, "CoinBlocker IPs List",
                        null, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)9,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/MiningServerIPList.txt"
                    },
                    {
                        (ushort)130, false, null, null, "Blocks Locky from payment site servers by IP address.", null,
                        null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null,
                        (byte)7, null, "Ransomware Tracker Locky Ransomware Payment Sites IP Blocklist", null, null,
                        null, (byte)9, "https://ransomwaretracker.abuse.ch/downloads/LY_PS_IPBL.txt"
                    },
                    {
                        (ushort)125, false, null, null, "Blocks TeslaCrypt from payment site servers by IP address.",
                        null, null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/",
                        null, (byte)7, null, "Ransomware Tracker TeslaCrypt Ransomware Payment Sites IP Blocklist",
                        null, null, null, (byte)9, "https://ransomwaretracker.abuse.ch/downloads/TC_PS_IPBL.txt"
                    },
                    {
                        (ushort)123, false, null, null,
                        "Blocks TorrentLocker from botnet command and control servers by IP address.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker TorrentLocker Ransomware C2 IP Blocklist", null, null, null, (byte)9,
                        "https://ransomwaretracker.abuse.ch/downloads/TL_C2_IPBL.txt"
                    },
                    {
                        (ushort)121, false, null, null, "Blocks TorrentLocker from payment site servers by IP address.",
                        null, null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/",
                        null, (byte)7, null, "Ransomware Tracker TorrentLocker Ransomware Payment Sites IP Blocklist",
                        null, null, null, (byte)9, "https://ransomwaretracker.abuse.ch/downloads/TL_PS_IPBL.txt"
                    },
                    {
                        (ushort)75, false, null, null, "Blocks Locky from botnet command and control servers by IP.",
                        null, null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/",
                        null, (byte)7, null, "Ransomware Tracker Locky Ransomware C2 IP Blocklist", null, null, null,
                        (byte)9, "https://ransomwaretracker.abuse.ch/downloads/LY_C2_IPBL.txt"
                    },
                    {
                        (ushort)23, false, null, null, "Blocks CryptoWall from payment site servers by IP address.",
                        null, null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/",
                        null, (byte)7, null, "Ransomware Tracker CryptoWall Ransomware Payment Sites IP Blocklist",
                        null, null, null, (byte)9, "https://ransomwaretracker.abuse.ch/downloads/CW_PS_IPBL.txt"
                    },
                    {
                        (ushort)21, false, null, null, "A combined IP blocklist for blocking ransomware.", null, null,
                        null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7,
                        null, "Ransomware Tracker IP Blocklist", null, null, null, (byte)9,
                        "https://ransomwaretracker.abuse.ch/downloads/RW_IPBL.txt"
                    },
                    {
                        (ushort)389, false, null, null,
                        "Here's how this list works. This is a categorised list of URLs that clot up Google search results. The list is designed for use with Personal Blocklist (and its Import function) for Google Search and Google Chrome users, in such a way that it removes search results for the URLs from your Google searches. If any other URL-based search-result-blockers for other search engines (incl. for Google Image Search) and browsers exist out there, feel free to tell me about them. The list is VERY subjective, so quite a few of you may NOT want to block the results for ALL of these URLs. In that case, simply pick whichever ones from this buffet that you want to block, and paste them into Personal Blocklist. While this list is technically possible to add to adblocker tools, it'd be a very bad idea to do so, since you wouldn't have any control over which URLs you'll be able to block outright or not.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's list for Chrome Personal Blocklist", null, null, null, (byte)8,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/List%20for%20Chrome%20Personal%20Blocklist"
                    },
                    {
                        (ushort)312, false, null, null, "A generic list that makes annoying sticky headers unsticky.",
                        "https://raw.githubusercontent.com/elypter/filter_processor/master/generated_filterlists/blockhead(decoy_generic_extraction).txt",
                        null, null, null, null, "https://github.com/elypter/filter_processor",
                        "https://github.com/elypter/filter_processor/issues", (byte)4, null,
                        "Blockhead (Generic Extraction Based)", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/elypter/filter_processor/master/generated_filterlists/blockhead(decoy_generic_extraction).txt"
                    },
                    {
                        (ushort)348, false, null, null, null, null, null, null, null, null, "http://vxvault.net/", null,
                        (byte)5, null, "VXVault", null, null, null, (byte)8, "http://vxvault.net/URL_List.php"
                    },
                    {
                        (ushort)127, false, null, null, "Blocks TeslaCrypt from distribution site servers by URL.",
                        null, null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/",
                        null, (byte)7, null, "Ransomware Tracker TeslaCrypt Ransomware Distribution Site URL Blocklist",
                        null, null, null, (byte)8, "https://ransomwaretracker.abuse.ch/downloads/TC_DS_URLBL.txt"
                    },
                    {
                        (ushort)120, false, null, null, "A combined URL blocklist for blocking ransomware.", null, null,
                        null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7,
                        null, "Ransomware Tracker URL Blocklist", null, null, null, (byte)8,
                        "https://ransomwaretracker.abuse.ch/downloads/RW_URLBL.txt"
                    },
                    {
                        (ushort)76, false, null, null, "Blocks Locky from distribution site servers by URL.", null,
                        null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null,
                        (byte)7, null, "Ransomware Tracker Locky Ransomware Distribution Site URL Blocklist", null,
                        null, null, (byte)8, "https://ransomwaretracker.abuse.ch/downloads/LY_DS_URLBL.txt"
                    },
                    {
                        (ushort)25, false, null, null,
                        "Blocks CryptoWall from botnet command and control servers by URL.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker CryptoWall Ransomware C2 URL Blocklist", null, null, null, (byte)8,
                        "https://ransomwaretracker.abuse.ch/downloads/CW_C2_URLBL.txt"
                    },
                    {
                        (ushort)371, false, null, null,
                        "AFNIL’s intention is to merge third-party lists of known fakenews sites and make them usable for programs that can block.",
                        "https://afnil-antifakenewsinternationallist.github.io/AFNIL/", null, null, null, null,
                        "https://afnil-antifakenewsinternationallist.github.io/AFNIL/",
                        "https://github.com/AFNIL-AntiFakeNewsInternationalList/AFNIL/issues", (byte)4, null,
                        "AFNIL - Anti Fake News International List", null,
                        new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)7,
                        "https://raw.githubusercontent.com/AFNIL-AntiFakeNewsInternationalList/AFNIL/master/AFNIL-ABP-uBO.txt"
                    },
                    {
                        (ushort)368, false, null, null, "uMatrix ruleset unbreaks all Alexa 100 and more at site level",
                        "https://github.com/uMatrix-Rules/uMatrix-Rules-Site", null, null, "lolipopplus@protonmail.com",
                        null, "https://umatrix-rules.github.io/",
                        "https://github.com/uMatrix-Rules/uMatrix-Rules-Site/issues", (byte)9, null,
                        "uMatrix Rules - Site", null, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null, (byte)7,
                        "https://raw.githubusercontent.com/uMatrix-Rules/uMatrix-Rules-Site/master/rules.txt"
                    },
                    {
                        (ushort)367, false, null, null,
                        "uMatrix ruleset unbreaks all Alexa 100 and more at domain level",
                        "https://github.com/uMatrix-Rules/uMatrix-Rules-Domain", null, null,
                        "lolipopplus@protonmail.com", null, "https://umatrix-rules.github.io/",
                        "https://github.com/uMatrix-Rules/uMatrix-Rules-Domain/issues", (byte)9, null,
                        "uMatrix Rules - Domain", null,
                        new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)7,
                        "https://raw.githubusercontent.com/uMatrix-Rules/uMatrix-Rules-Domain/master/rules.txt"
                    },
                    {
                        (ushort)351, false, null, null,
                        "This is an AdGuard-specific supplement for the Adblock polskie reguły filter. It specifically removes adverts on Polish language websites.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#polish-ads-filter",
                        new DateTime(2018, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Polish Filter (Obsolete)", "https://kb.adguard.com/en/general/adguard-filter-policy",
                        null, null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/238.txt"
                    },
                    {
                        (ushort)350, false, null, null,
                        "Filter that enables removing of the ads from websites with French content.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#french-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null, "AdGuard French Filter",
                        "https://kb.adguard.com/en/general/adguard-filter-policy", null, null, (byte)6,
                        "https://filters.adtidy.org/extension/chromium/filters/16.txt"
                    },
                    {
                        (ushort)349, false, "https://discord.me/polskiefiltry", null,
                        "Supplement list for Polish Annoyance Filters, only for uBlock & AdGuard.",
                        "https://github.com/PolishFiltersTeam/PolishAnnoyanceFilters", null, null, null, null,
                        "https://polishannoyancefilters.netlify.com",
                        "https://github.com/PolishFiltersTeam/PolishAnnoyanceFilters/issues", (byte)9, null,
                        "Polish Annoyance Filters - Supplement for uBlock & AdGuard", null,
                        new DateTime(2017, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "https://polishannoyancefilters.netlify.com/issues", (byte)6,
                        "https://raw.githubusercontent.com/PolishFiltersTeam/PolishAnnoyanceFilters/master/PPB_uBlock_AdGuard.txt"
                    },
                    {
                        (ushort)345, false, "https://discord.me/polskiefiltry", null,
                        "AdGuard supplement list for Official Polish Filters for AdBlock, uBlock Origin & AdGuard",
                        null, null, "https://patronite.pl/polskiefiltry", "errors@certyficate.it", null,
                        "https://www.certyficate.it/", "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9,
                        null, "Official Polish Filters for AdBlock, uBlock Origin & AdGuard - Supplement for AdGuard",
                        null, new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)6,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/polish-adblock-filters/adblock_adguard.txt"
                    },
                    {
                        (ushort)172, false, null, null,
                        "The most complete and accurate list to block ads, tracers and other Internet crap on smartphones and PCs.",
                        "https://github.com/collinbarrett/FilterLists/issues/280", null,
                        "https://paypal.me/hajdarkakud", "hajdar@tutanota.com", "https://t.me/adzparticipation",
                        "https://adzhosts.fr/", null, (byte)5, null, "AdZHosts", null, null, null, (byte)6,
                        "https://adzhosts.eu/hosts/AdZGuardFilter.txt"
                    },
                    {
                        (ushort)169, false, null, null,
                        "Blocks irritating elements on webpages, including cookie notices, third-party widgets and in-page popups (Doesn’t include social media widgets and buttons, to block them you can still use Social media filter separately). It was inspired by Fanboy Annoyances List, but doesn’t duplicate it, so you can use them both together.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#annoyances-filter", null, null, null,
                        "https://forum.adguard.com/index.php?categories/filter-rules.66/",
                        "https://github.com/AdguardTeam/AdguardFilters",
                        "https://github.com/AdguardTeam/AdguardFilters/issues", (byte)12, null,
                        "AdGuard Annoyances Filter", "https://kb.adguard.com/en/general/adguard-filter-policy", null,
                        null, (byte)6, "https://filters.adtidy.org/extension/chromium/filters/14.txt"
                    },
                    {
                        (ushort)128, false, null, null,
                        "Blocks TeslaCrypt from botnet command and control servers by URL.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker TeslaCrypt Ransomware C2 URL Blocklist", null, null, null, (byte)8,
                        "https://ransomwaretracker.abuse.ch/downloads/TC_C2_URLBL.txt"
                    },
                    {
                        (ushort)26, false, null, null,
                        "Blocks CryptoWall from botnet command and control servers by domain.", null, null, null,
                        "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null, (byte)7, null,
                        "Ransomware Tracker CryptoWall Ransomware C2 Domain Blocklist", null, null, null, (byte)2,
                        "https://ransomwaretracker.abuse.ch/downloads/CW_C2_DOMBL.txt"
                    },
                    {
                        (ushort)311, false, null, null,
                        "A generic filter for adblockers that keeps annoying header and footer bars from filling up your screen.",
                        "https://github.com/elypter/generic_annoying_stickybar_filter",
                        new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/elypter/generic_annoying_stickybar_filter",
                        "https://github.com/elypter/generic_annoying_stickybar_filter/issues", (byte)4, null,
                        "Generic Annoying Stickybar Filter", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/elypter/generic_annoying_stickybar_filter/master/generic_header_list.txt"
                    },
                    {
                        (ushort)90, false, null, null,
                        "These filters are experimental and may cause breakage. They are being evaluated/fine-tuned for inclusion in the default set of filters.",
                        "https://github.com/uBlockOrigin/uAssets/blob/master/filters/experimental.txt", null, null,
                        null, null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)5, null, "uAssets Experimental", null,
                        null, null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/experimental.txt"
                    },
                    {
                        (ushort)386, false, null, null,
                        "The Sami indigenous people, spanning 4 official countries, and 6 actively used Sami languages, deserve a list of their own to bolster their proudness.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Tidy Sami-languages Internet List", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/S%C3%A1megiella-interneahttalisttu.txt"
                    },
                    {
                        (ushort)385, false, null, null,
                        "Are you tired of having to use Paint to remove potentially sensitive usernames, each and every time you're making a compilation of social media posts? Say no more! This list will remove posters' usernames from the biggest compilation sources, so that you can simply take a screencap and add it directly into your video/timeline!",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Username Hider for Compilation Creators", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Username%20Hider%20for%20Compilation%20Creators.txt"
                    },
                    {
                        (ushort)384, false, null, null,
                        "This list is made so as to make it a lot easier on paper to use Norwegian cashback services without necessarily having to turn off your adblocker. This is because it'll prevent your adblocker from working on these sites, as adblockers have otherwise been known to interrupt cashback recognition mechanisms. It's currently tailored to users of Kickback, ViaTrumf and Norwegian Reward.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null, "Norwegian Cashback Helper",
                        null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianCashbackHelper.txt"
                    },
                    {
                        (ushort)381, false, null, null, "Saving the Internets... one roll at a time.",
                        "http://rickrolldb.com/", null, null, null, null, "http://rickrolldb.com/",
                        "https://github.com/jamiew/rickrolldb/issues", (byte)5, null, "Rickroll Blacklist", null, null,
                        "http://rickrolldb.com/", (byte)3, "http://rickrolldb.com/ricklist.txt"
                    },
                    {
                        (ushort)377, false, null, null, "A block list of malicious domains.",
                        "https://github.com/cb-software/CB-Malicious-Domains/blob/master/README.md", null, null, null,
                        null, "https://github.com/cb-software/CB-Malicious-Domains",
                        "https://github.com/cb-software/CB-Malicious-Domains/issues", (byte)2, null,
                        "CB Malicious Domains", null, new DateTime(2018, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null, (byte)3,
                        "https://raw.githubusercontent.com/cb-software/CB-Malicious-Domains/master/block_lists/adblock_plus.txt"
                    },
                    {
                        (ushort)376, false, null, null, "Blocks title screen ads on several large MMO game websites.",
                        "https://github.com/collinbarrett/FilterLists/issues/257", null, null, null, null,
                        "https://github.com/haykam821/Blocklists", "https://github.com/haykam821/Blocklists/issues",
                        (byte)2, null, "Haykam's MMO List", null,
                        new DateTime(2018, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/haykam821/Blocklists/master/mmo.txt"
                    },
                    {
                        (ushort)375, false, null, null,
                        "A comprehensive, all-in-one adblock list for thorough blocking of trackers, popup ads, ads, unwanted cookies, fake news, cookie warning messages, unwanted comment sections, crypto-coin mining, YouTube clutter and social network hassles.",
                        "https://hl2guide.github.io/All-in-One-Customized-Adblock-List/", null, null, null, null,
                        "https://hl2guide.github.io/All-in-One-Customized-Adblock-List/",
                        "https://github.com/hl2guide/All-in-One-Customized-Adblock-List/issues", (byte)2, null,
                        "All-in-One Customized Adblock List", null,
                        new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/hl2guide/All-in-One-Customized-Adblock-List/master/deanoman-adblocklist.txt"
                    },
                    {
                        (ushort)374, false, null, null, null, null,
                        new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/Hubird-au/Adversity", "https://github.com/Hubird-au/Adversity/issues",
                        (byte)16, null, "Adversity - Extreme Measures", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/Hubird-au/Adversity/master/Extreme-Measures.txt"
                    },
                    {
                        (ushort)373, false, null, null, null, null,
                        new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/Hubird-au/Adversity", "https://github.com/Hubird-au/Adversity/issues",
                        (byte)16, null, "Adversity - Antisocial", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/Hubird-au/Adversity/master/Antisocial.txt"
                    },
                    {
                        (ushort)372, false, null, null, null, null,
                        new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/Hubird-au/Adversity", "https://github.com/Hubird-au/Adversity/issues",
                        (byte)16, null, "Adversity", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/Hubird-au/Adversity/master/Adversity.txt"
                    },
                    {
                        (ushort)356, false, null, null, "ReStyle annoying pages",
                        "https://github.com/eladkarako/hosts/blob/master/build/hosts_adblock_anti_annoyances_style_inject.txt",
                        null, "https://www.paypal.me/e1adkarak0", null, null, "https://github.com/eladkarako/hosts",
                        null, (byte)11, null, "HOSTS AdBlock - Anti-Annoyance - ReStyle Annoying Pages", null,
                        new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/eladkarako/hosts/master/build/hosts_adblock_anti_annoyances_style_inject.txt"
                    },
                    {
                        (ushort)355, false, null, null, "Hide annoying elements",
                        "https://github.com/eladkarako/hosts/blob/master/build/hosts_adblock_anti_annoyances_hide.txt",
                        null, "https://www.paypal.me/e1adkarak0", null, null, "https://github.com/eladkarako/hosts",
                        null, (byte)11, null, "HOSTS AdBlock - Anti-Annoyance - Hide Annoying Elements", null,
                        new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/eladkarako/hosts/master/build/hosts_adblock_anti_annoyances_hide.txt"
                    },
                    {
                        (ushort)354, false, null, null, "Block annoying page-scripts",
                        "https://github.com/eladkarako/hosts/blob/master/build/hosts_adblock_anti_annoyances_block_inline_script.txt",
                        null, "https://www.paypal.me/e1adkarak0", null, null, "https://github.com/eladkarako/hosts",
                        null, (byte)11, null, "HOSTS AdBlock - Anti-Annoyance - Block Annoying Page-Scripts", null,
                        new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/eladkarako/hosts/master/build/hosts_adblock_anti_annoyances_block_inline_script.txt"
                    },
                    {
                        (ushort)353, false, null, null, "Block annoying connections",
                        "https://github.com/eladkarako/hosts/blob/master/build/hosts_adblock_anti_annoyances_block.txt",
                        null, "https://www.paypal.me/e1adkarak0", null, null, "https://github.com/eladkarako/hosts",
                        null, (byte)11, null, "HOSTS AdBlock - Anti-Annoyance - Block Annoying Connections", null,
                        new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/eladkarako/hosts/master/build/hosts_adblock_anti_annoyances_block.txt"
                    },
                    {
                        (ushort)352, false, null, null, "A bad hosts blocking list", null, null,
                        "https://www.paypal.me/e1adkarak0", null, null, "https://github.com/eladkarako/hosts", null,
                        (byte)11, null, "HOSTS AdBlock", null,
                        new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/eladkarako/hosts/master/build/hosts_adblock.txt"
                    },
                    {
                        (ushort)346, false, "https://discord.me/polskiefiltry", null,
                        "Test supplement list for Official Polish Filters for AdBlock, uBlock Origin & AdGuard", null,
                        null, "https://patronite.pl/polskiefiltry", null, null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null,
                        "Official Polish Filters for AdBlock, uBlock Origin & AdGuard - Test Supplement", null,
                        new DateTime(2017, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/polish-adblock-filters/adblock_test.txt"
                    },
                    {
                        (ushort)344, false, "https://discord.me/polskiefiltry", null,
                        "Blocks internal advertising, paid subscriptions, own stores on Polish sites.", null, null,
                        "https://authedmine.com/media/miner.html?key=ZpmDZUFJhHdv1YZHpCHFWhAUQIGa67TV", null, null,
                        "https://github.com/KonoromiHimaries/PolishSubFilters/", null, (byte)9, null,
                        "Polish Internal Filters", null,
                        new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/KonoromiHimaries/PolishSubFilters/master/internal-filters/wewnetrzne.txt"
                    },
                    {
                        (ushort)342, false, "https://discord.me/polskiefiltry", null,
                        "Blocks banners (paypal, payu, bitcoin and patronite), charity banners, other forms of inclination to support on Polish sites.",
                        null, null, "https://authedmine.com/media/miner.html?key=ZpmDZUFJhHdv1YZHpCHFWhAUQIGa67TV",
                        null, null, "https://github.com/KonoromiHimaries/PolishSubFilters", null, (byte)9, null,
                        "Polish Anti-Donate Filters", null,
                        new DateTime(2018, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/KonoromiHimaries/PolishSubFilters/master/internal-filters/anti-donate-filters/anty-donacje.txt"
                    },
                    {
                        (ushort)332, false, null, null,
                        "Get rid of \"Overlay Popups\" that trying to integrate your social network account, force you to like and/or follow pages and other accounts.",
                        "https://github.com/kowith337/ThaiAntiForceLike/blob/master/README.md", null, null, null, null,
                        "https://github.com/kowith337/ThaiAntiForceLike",
                        "https://github.com/kowith337/ThaiAntiForceLike/issues", (byte)5, null, "ThaiAntiForceLike",
                        null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/kowith337/ThaiAntiForceLike/master/AntiForceLike.txt"
                    },
                    {
                        (ushort)327, false, null, null,
                        "Removes \"Download Our App\" banners from mobile website versions, for those who prefer their phone web browsers instead of apps.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Staying On The Phone Browser", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/stayingonbrowser/Staying%20On%20The%20Phone%20Browser"
                    },
                    {
                        (ushort)315, false, null, null,
                        "Filters, which makes easer to use of the largest Polish trading platforms like Allegro, Ceneo, eBay, OLX and Sprzedajemy and other, blocking unnecessary, annoying and potentially dangerous elements - ads, sponsored articles, or scripts that track user's activities. They enable simpler and faster use of supported websites without limiting their functionality, while increasing the privacy of buyers and sellers.",
                        "https://alleblock.pl/", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=RN7R64TJLWQW6",
                        "blablabla@alleblock.pl", null, "https://alleblock.pl/",
                        "https://github.com/maciejtarmas/AlleBlock/issues", (byte)13, null, "AlleBlock", null, null,
                        null, (byte)3, "https://alleblock.pl/alleblock/alleblock.txt"
                    },
                    {
                        (ushort)314, false, null, null,
                        "No Coin is a tiny browser extension aiming to block coin miners such as Coinhive.",
                        "https://github.com/keraf/NoCoin", null, "https://paypal.me/keraf", null, null,
                        "https://github.com/keraf/NoCoin", "https://github.com/keraf/NoCoin/issues", (byte)4, null,
                        "Cryptocurrency (Bitcoin) Mining Protection List", null, null, null, (byte)3,
                        "https://cdn.adblockcdn.com/filters/nominers.txt"
                    },
                    {
                        (ushort)307, false, null, null, "Blocks various trackers", null, null, null, null, null,
                        "https://github.com/taylr/linkedinsanity", "https://github.com/taylr/linkedinsanity/issues",
                        (byte)2, null, "Spies Dislike Us Having Privacy", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/taylr/linkedinsanity/master/spies-dislike-us.txt"
                    },
                    {
                        (ushort)306, false, null, null, "Block only suggestions.", "https://youtube.adblockplus.me/",
                        null, "https://adblockplus.org/en/donate", "subscriptionlist@adblockplus.org", null,
                        "https://youtube.adblockplus.me/", null, (byte)5, null, "YouTube: Remove Youtube Suggestions",
                        null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/yt_annoyances_suggestions.txt"
                    },
                    {
                        (ushort)305, false, null, null,
                        "Official filter list file used for blocking ads on Czech and Slovak websites.",
                        "https://github.com/tomasko126/easylistczechandslovak", null, null, "tomastaro@adblock.sk",
                        "https://easylist-czech-and-slovak.tenderapp.com/", "https://adblock.sk/",
                        "https://github.com/tomasko126/easylistczechandslovak/issues", (byte)8, null,
                        "EasyList Czech and Slovak", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/tomasko126/easylistczechandslovak/master/filters.txt"
                    },
                    {
                        (ushort)300, false, null, null, "Chinese supplement for the EasyList filters.",
                        "https://easylist-downloads.adblockplus.org/easylistchina.txt", null, null,
                        "easylist.china@gmail.com", "https://abpchina.org/forum/forum.php",
                        "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667", null, (byte)5, null,
                        "EasyList China", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/easylistchina.txt"
                    },
                    {
                        (ushort)299, false, null, null, "A list combining EasyList China and EasyList.", null, null,
                        null, null, null, null, null, (byte)5, null, "EasyList China + EasyList", null, null, null,
                        (byte)3, "https://easylist-downloads.adblockplus.org/easylistchina+easylist.txt"
                    },
                    {
                        (ushort)387, false, null, null,
                        "Removes ads, affiliation ads, and empty boxes on Norwegian sites to produce a cleaner browser experience. Meant to be used on top of general filters.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Norwegian Filters for Tidier Websites (iOS Safari)", null, null, null,
                        (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList%20alternate%20versions/DandelionSproutsNorskeFiltre.json"
                    },
                    {
                        (ushort)390, false, "https://discord.me/polskiefiltry", null,
                        "Filters that hide and block RSS sections on Polish websites (supplement for Polish Social Filters).",
                        "https://github.com/PolishFiltersTeam/PolishRSSFilters", null, null, null, null,
                        "https://github.com/PolishFiltersTeam/PolishRSSFilters",
                        "https://github.com/PolishFiltersTeam/PolishRSSFilters/issues", (byte)9, null,
                        "Polish RSS Filters", null, new DateTime(2018, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null, (byte)3,
                        "https://raw.githubusercontent.com/PolishFiltersTeam/PolishRSSFilters/master/polish_rss_filters.txt"
                    },
                    {
                        (ushort)391, false, null, null,
                        "Removes popular games and most bad games from the front pages of various webstores and app stores.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null, "I Hate Overpromoted Games",
                        null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/IHateOverpromotedGames.txt"
                    },
                    {
                        (ushort)392, false, null, null,
                        "Intends to make it easier to browse various websites without being forced by various nag-windows to log in. At the time of writing (15th of May 2018) it chiefly supports Pinterest, Facebook and Pixiv.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Browsing websites without logging in", null,
                        new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/BrowseWebsitesWithoutLoggingIn.txt"
                    },
                    {
                        (ushort)89, false, null, null, "Filters optimized for uBlock.",
                        "https://github.com/uBlockOrigin/uAssets/blob/master/filters/filters.txt", null, null, null,
                        null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)5, null, "uAssets Filters", null, null,
                        null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/filters.txt"
                    },
                    {
                        (ushort)88, false, null, null, "Privacy filters for uBlock Origin.", null, null, null, null,
                        null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)5, null, "uAssets Privacy", null, null,
                        null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/privacy.txt"
                    },
                    {
                        (ushort)87, false, null, null,
                        "Needed to unbreak web sites, mostly because of hosts file-based filters.",
                        "https://github.com/uBlockOrigin/uAssets/blob/master/filters/unbreak.txt", null, null, null,
                        null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)5, null, "uAssets Unbreak", null, null,
                        null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/unbreak.txt"
                    },
                    {
                        (ushort)86, false, null, null, "Block sites with skimming scripts.",
                        "https://raw.githubusercontent.com/byaka/ublock-antiskimming-list/master/build/data.txt",
                        new DateTime(2017, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/byaka/ublock-antiskimming-list",
                        "https://github.com/byaka/ublock-antiskimming-list/issues", (byte)5, null,
                        "uBlock Antiskimming List", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/byaka/ublock-antiskimming-list/master/build/data.txt"
                    },
                    {
                        (ushort)85, false, null, null,
                        "A filterlist with additional filters for uBlock Origin. Contains filters specific to uBlock Origin (like popunder filters) and some filters that have not yet been added to other filterlists.",
                        "https://github.com/IDKwhattoputhere/uBlock-Filters-Plus", null, null, null, null,
                        "https://github.com/IDKwhattoputhere/uBlock-Filters-Plus",
                        "https://github.com/IDKwhattoputhere/uBlock-Filters-Plus/issues", (byte)5, null,
                        "uBlock Filters Plus", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/IDKwhattoputhere/uBlock-Filters-Plus/master/uBlock-Filters-Plus.txt"
                    },
                    {
                        (ushort)84, false, "https://discord.me/polskiefiltry", null,
                        "uBlock Origin supplement list for Official Polish Filters for AdBlock, uBlock Origin & AdGuard",
                        null, null, "https://patronite.pl/polskiefiltry", "errors@certyficate.it", null,
                        "https://www.certyficate.it/", "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9,
                        null, "Official Polish Filters for AdBlock, uBlock Origin & AdGuard - Supplement for uBlock",
                        null, new DateTime(2018, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)4,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/polish-adblock-filters/adblock_ublock.txt"
                    },
                    {
                        (ushort)83, false, null, null,
                        "This project was built based on Anti-Adblock Killer (by Reek), but is now significantly different. Anti-Adblock Killer Script was completely re-implemented. Anti-Adblock Killer Filter was mostly copied and concatenated to uBlock Protector List.",
                        "https://github.com/jspenguin2017/uBlockProtector", null, null, null, null,
                        "https://jspenguin2017.github.io/uBlockProtector",
                        "https://github.com/jspenguin2017/uBlockProtector/issues", (byte)5, null,
                        "Nano Defender Integration", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/NanoAdblocker/NanoFilters/master/NanoMirror/NanoDefender.txt"
                    },
                    {
                        (ushort)82, false, null, null,
                        "A filterlist with additional filters for uBlock Origin to block third-party, tracking, annoyances and all other unwarranted resources from loading. Contains filters specific to uBlock Origin and some filters that have not yet been added to other filterlists.",
                        "https://github.com/uBlock-user/uBO-Personal-Filters", null, null, null, null,
                        "https://github.com/uBlock-user/uBO-Personal-Filters", null, (byte)5, null,
                        "uBO-Personal-Filters", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/uBlock-user/uBO-Personal-Filters/master/uPF.txt"
                    },
                    {
                        (ushort)27, false, null, null,
                        "A text file with filters to aid in blocking online trackers, for use in a blocker such as uBlock Origin.",
                        "https://github.com/metaphoricgiraffe/tracking-filters", null, null, null, null,
                        "https://github.com/metaphoricgiraffe/tracking-filters",
                        "https://github.com/metaphoricgiraffe/tracking-filters/issues", (byte)11, null,
                        "Privacy Filters", null, null, null, (byte)4,
                        "https://raw.githubusercontent.com/metaphoricgiraffe/tracking-filters/master/trackingfilters.txt"
                    },
                    {
                        (ushort)508, false, null, null,
                        "Whitelist of section with promotion of fake science/news. More at: https://github.com/azet12/KAD/issues/649.",
                        "https://github.com/azet12/KAD", null, null, "kadrep@outlook.com", null,
                        "https://azet12.github.io/KAD/", "https://github.com/azet12/KAD/issues", (byte)8, null,
                        "KAD - The Whitelist of the Controversial Pages", null, null,
                        "https://azet12.github.io/KAD/informacje.html#form1-35", (byte)3,
                        "https://raw.githubusercontent.com/azet12/KAD/gh-pages/assets/other/kadfakewhitelist.txt"
                    },
                    {
                        (ushort)506, false, null, null, "Allow nonintrusive advertising without third-party tracking",
                        "https://easylist-downloads.adblockplus.org/exceptionrules-privacy-friendly.txt", null, null,
                        "info@eyeo.com", null, "https://acceptableads.com/", null, (byte)5, null,
                        "Acceptable Ads without third-party tracking", null, null, null, (byte)3,
                        "https://easylist-downloads.adblockplus.org/exceptionrules-privacy-friendly.txt"
                    },
                    {
                        (ushort)505, false, null, null,
                        "This serves as a template and guidance for people who want to learn how to make their own adblock lists. This template contains all conventionally used tags; the 'Beginner' version is easier to deal with.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Adblock List Template (Novice)", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Adblock%20list%20templates/Adblock%20list%20template%20-Novice-.txt"
                    },
                    {
                        (ushort)504, false, null, null,
                        "This serves as a template and guidance for people who want to learn how to make their own adblock lists. This template contains the bare-bones necessities; the 'Novice' version has more tags and explanations.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Adblock List Template (Beginner)", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Adblock%20list%20templates/Adblock%20list%20template%20-Beginner-.txt"
                    },
                    {
                        (ushort)91, false, null, null,
                        "To block sites known for delivering adware/crapware. For sites documented to put users at risk of installing adware/crapware etc. The purpose is to at least ensure a user is warned of the risks ahead.",
                        "https://github.com/uBlockOrigin/uAssets/blob/master/filters/badware.txt", null, null, null,
                        null, "https://github.com/uBlockOrigin/uAssets",
                        "https://github.com/uBlockOrigin/uAssets/issues", (byte)5, null, "uAssets Badware", null, null,
                        null, (byte)4,
                        "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/badware.txt"
                    },
                    {
                        (ushort)479, false, null, null, null, null, null, null, "easylist.polish@gmail.com", null,
                        "https://easylist.to", "easylist.polish@gmail.com", (byte)4, null, "EasyList Polish", null,
                        null, null, (byte)3, "https://easylist-downloads.adblockplus.org/easylistpolish.txt"
                    },
                    {
                        (ushort)468, false, null, null, "list for bad isueads", null, null, null, null, null, null,
                        "https://github.com/kano1/I/issues", (byte)5, null, "Adware Filter Block", null, null, null,
                        (byte)3, "https://github.com/kano1/I/raw/master/adware.txt"
                    },
                    {
                        (ushort)467, false, null, null, "Domain Bad Isue Ads", null, null, null, null, null, null,
                        "https://github.com/kano1/I/issues", (byte)5, null, "Adware BL(By Garuda)", null, null, null,
                        (byte)3, "https://github.com/kano1/I/raw/master/badway.txt"
                    },
                    {
                        (ushort)466, false, null, null, null, null, null, null, null, null, null,
                        "https://github.com/kano1/I/issues", (byte)5, null, "Kano1 Simple List", null, null, null,
                        (byte)3, "https://github.com/kano1/I/raw/master/adblock.txt"
                    },
                    {
                        (ushort)462, false, null, null,
                        "A comprehensive, all-in-one ad-block list in order to block Malware Domains.", null, null,
                        "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's Malware Filter List", null, null, null, (byte)3,
                        "https://github.com/CHEF-KOCH/CKs-FilterList/raw/master/Malware/CK's-Malware-FilterList.txt"
                    },
                    {
                        (ushort)454, false, null, null,
                        "Blocks all suspicious, unverified, fake, duplicate or malfunction torrent trackers. ", null,
                        null, "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's BadTorrentTracker Filter List", null, null, null, (byte)3,
                        "https://github.com/CHEF-KOCH/CKs-FilterList/raw/master/Torrent/CK's-Torrent-FilterList.txt"
                    },
                    {
                        (ushort)453, false, null, null, "Block all external Fonts.", null, null,
                        "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's Fonts Filter List", null, null, null, (byte)3,
                        "https://github.com/CHEF-KOCH/CKs-FilterList/raw/master/Fonts/CK's-Fonts-FilterList.txt"
                    },
                    {
                        (ushort)452, false, null, null,
                        "A comprehensive, all-in-one ad-block list for Android. Apps and OS related traffic, it's designed to filter 'unneeded' Android connections. The list is only tested against AdGuard!",
                        null, null, "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's Android Filter List", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/CHEF-KOCH/CKs-FilterList/master/Android/CK's-Android-FilterList.txt"
                    },
                    {
                        (ushort)434, false, null, null,
                        "Are you tired of having to turn off autoplay on YouTube every time you e.g. go to incognito mode? Are you worried of having to use specific extensions just for that purpose? Then this list is for you.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null, "Stop Autoplay on YouTube",
                        null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/StopAutoplayOnYouTube.txt"
                    },
                    {
                        (ushort)432, false, null, null,
                        "Do you feel that Friendship is Magic has overstayed its welcome? Here's a list that'll let you keep more of a distance to it.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null, "Anti-FіМ List", null, null,
                        null, (byte)3,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Anti-F%D1%96%D0%9C%20List.txt"
                    },
                    {
                        (ushort)429, false, null, null,
                        "International List consists mostly of static cosmetic filters. English and few German websites are included. As regards tracking filters, they have been partly copied from other privacy filter lists.",
                        "https://github.com/betterwebleon/international-list#international-list", null, null, null,
                        null, "https://github.com/betterwebleon/international-list",
                        "https://github.com/betterwebleon/international-list/issues", (byte)11, null,
                        "International List", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/betterwebleon/international-list/master/filters.txt"
                    },
                    {
                        (ushort)403, false, null, null,
                        "This filter aims to remove emoji realted scripts, stylesheets, fonts, and images.",
                        "https://github.com/lassekongo83/Frellwits-filter-lists#available-lists", null, null, null,
                        null, "https://github.com/lassekongo83/Frellwits-filter-lists",
                        "https://github.com/lassekongo83/Frellwits-filter-lists/issues", (byte)4, null,
                        "I Don't Care About Emojis", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/lassekongo83/Frellwits-filter-lists/master/emoji-filter.txt"
                    },
                    {
                        (ushort)402, false, null, null, null, null,
                        new DateTime(2015, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://startshop.no/", null, (byte)5, null, "Startshop ABP Filters", null, null, null,
                        (byte)3, "https://startshop.no/filter/abp"
                    },
                    {
                        (ushort)394, false, null, null,
                        "A comprehensive, all-in-one ad-block list for thorough blocking of trackers, pop-up ads, ads, unwanted cookies, fake news, cookie warning messages, unwanted comment sections, crypto-coin mining, YouTube clutter and social network hassles.",
                        "https://raw.githubusercontent.com/CHEF-KOCH/CKs-FilterList/master/CK%27s-FilterList.txt", null,
                        null, "CHEF-KOCH@protonmail.com", null, "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null, "CHEF-KOCH's Filter List",
                        null, new DateTime(2015, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)3,
                        "https://raw.githubusercontent.com/CHEF-KOCH/CKs-FilterList/master/CK%27s-FilterList.txt"
                    },
                    {
                        (ushort)469, false, null, null,
                        "list for keloger,system tracker,cookie collector,malware tracker, and oter spyware", null,
                        null, null, null, null, null, "https://github.com/kano1/I/issues", (byte)5, null,
                        "Spyware Filter Block List", null, null, null, (byte)3,
                        "https://raw.githubusercontent.com/kano1/Kano/master/Spyware.txt"
                    },
                    {
                        (ushort)24, false, null, null, "Blocks CryptoWall from payment site servers by domain.", null,
                        null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null,
                        (byte)7, null, "Ransomware Tracker CryptoWall Ransomware Payment Sites Domain Blocklist", null,
                        null, null, (byte)2, "https://ransomwaretracker.abuse.ch/downloads/CW_PS_DOMBL.txt"
                    },
                    {
                        (ushort)122, false, null, null, "Blocks TorrentLocker from payment site servers by domain.",
                        null, null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/",
                        null, (byte)7, null,
                        "Ransomware Tracker TorrentLocker Ransomware Payment Sites Domain Blocklist", null, null, null,
                        (byte)2, "https://ransomwaretracker.abuse.ch/downloads/TL_PS_DOMBL.txt"
                    },
                    {
                        (ushort)8, false, null, null,
                        "The domains of Malware URLs to be used by security researchers and anti-malware researchers. It can also be used by individuals to protect themselves.",
                        "http://malwareurls.joxeankoret.com/",
                        new DateTime(2015, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "info@joxeankoret.com",
                        null, "http://malwareurls.joxeankoret.com/", null, (byte)2, null, "Malware URLs Domains", null,
                        null, null, (byte)2, "http://malwareurls.joxeankoret.com/domains.txt"
                    },
                    {
                        (ushort)195, false, null, null,
                        "The Feodo Tracker Feodo Domain Blocklist contains domain names (FQDN) used as C&C communication channel by the Feodo Trojan. These domains names are usually registered and operated by cybercriminals for the exclusive purpose of hosting a Feodo botnet controller. Hence you should expect no legit traffic to those domains. I highly recommend you to block/drop any traffic towards any Feodo C&C domain by using the Feodo Domain Blocklist. Please consider that domain names are usually only used by version B of the Feodo Trojan. C&C communication channels used by version A, version C and version D are not covered by this blocklist.",
                        "https://feodotracker.abuse.ch/blocklist/", null, null, "contactme@abuse.ch", null,
                        "https://feodotracker.abuse.ch/blocklist/", null, (byte)5, null,
                        "abuse.ch Feodo Domain Blocklist", null, null, null, null,
                        "https://feodotracker.abuse.ch/blocklist/?download=domainblocklist"
                    },
                    {
                        (ushort)194, false, null, null,
                        "The Feodo Tracker Feodo IP Blocklist contains IP addresses (IPv4) used as C&C communication channel by the Feodo Trojan. This lists contains two types of IP address: Feodo C&C servers used by version A, version C and version D of the Feodo Trojan (these IP addresses are usually compromised servers running an nginx daemon on port 8080 TCP or 7779 TCP that is acting as proxy, forwarding all traffic to a tier 2 proxy node) and Feodo C&C servers used by version B which are usually used for the exclusive purpose of hosting a Feodo C&C server. Attention: Since Feodo C&C servers associated with version A, version C and version D are usually hosted on compromised servers, its likely that you also block/drop legit traffic e.g. towards websites hosted on a certain IP address acting as Feodo C&C for version A, version C and version D. If you only want to block/drop traffic to Feodo C&C servers hosted on bad IPs (version B), please use the blocklist BadIPs documented below.",
                        "https://feodotracker.abuse.ch/blocklist/", null, null, "contactme@abuse.ch", null,
                        "https://feodotracker.abuse.ch/blocklist/", null, (byte)5, null, "abuse.ch Feodo IP Blocklist",
                        null, null, null, null, "https://feodotracker.abuse.ch/blocklist/?download=ipblocklist"
                    },
                    {
                        (ushort)193, false, null, null,
                        "This blocklist only contains compromised / hijacked websites (level 2) which are being abused by cybercriminals to host a ZeuS botnet controller.",
                        "https://zeustracker.abuse.ch/blocklist.php", null, "https://zeustracker.abuse.ch/faq.php",
                        "contactme@abuse.ch", null, "https://zeustracker.abuse.ch/blocklist.php", null, (byte)5, null,
                        "abuse.ch ZeuS Compromised URL Blocklist", null, null, null, null,
                        "https://zeustracker.abuse.ch/blocklist.php?download=compromised"
                    },
                    {
                        (ushort)192, false, null, null, "Dead sites based on BadHosts content.",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues",
                        (byte)5, null, "add.Dead", null, null, null, null,
                        "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.Dead/hosts"
                    },
                    {
                        (ushort)191, false, null, null, "Risk content sites based on BadHosts content.",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues",
                        (byte)5, null, "add.Risk", null, null, null, null,
                        "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.Risk/hosts"
                    },
                    {
                        (ushort)190, false, null, null, "Spam sites based on BadHosts content.",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues",
                        (byte)5, null, "add.Spam", null, null, null, null,
                        "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.Spam/hosts"
                    },
                    {
                        (ushort)189, false, null, null,
                        "A hosts list blocking advertising sites. (Compressed, currently cannot be subscribed to/added.)",
                        null, null, "http://rlwpx.free.fr/WPFF/don.htm", "contact.wiki.airelle@spamgourmet.com",
                        "http://rlwpx.free.fr/Webforum/", "http://rlwpx.free.fr/WPFF/hosts.htm", null, (byte)5, null,
                        "Airelle's Anti-Advertisements Hosts", null, null, null, null,
                        "http://rlwpx.free.fr/WPFF/hpub.7z"
                    },
                    {
                        (ushort)188, false, null, null,
                        "A hosts list blocking adult/pornographic sites. (Compressed, currently cannot be subscribed to/added.)",
                        null, null, "http://rlwpx.free.fr/WPFF/don.htm", "contact.wiki.airelle@spamgourmet.com",
                        "http://rlwpx.free.fr/Webforum/", "http://rlwpx.free.fr/WPFF/hosts.htm", null, (byte)5, null,
                        "Airelle's Anti-Sex Hosts", null, null, null, null, "http://rlwpx.free.fr/WPFF/hsex.7z"
                    },
                    {
                        (ushort)187, false, null, null, "A hosts list blocking tracking sites.", null, null,
                        "http://rlwpx.free.fr/WPFF/don.htm", "contact.wiki.airelle@spamgourmet.com",
                        "http://rlwpx.free.fr/Webforum/", "http://rlwpx.free.fr/WPFF/hosts.htm", null, (byte)5, null,
                        "Airelle's Anti-Trackers Hosts", null, null, null, null,
                        "https://v.firebog.net/hosts/Airelle-trc.txt"
                    },
                    {
                        (ushort)186, false, null, null, "A hosts list blocking malware sites.", null, null,
                        "http://rlwpx.free.fr/WPFF/don.htm", "contact.wiki.airelle@spamgourmet.com",
                        "http://rlwpx.free.fr/Webforum/", "http://rlwpx.free.fr/WPFF/hosts.htm", null, (byte)5, null,
                        "Airelle's Malware Hosts", null, null, null, null,
                        "https://v.firebog.net/hosts/Airelle-hrsk.txt"
                    },
                    {
                        (ushort)185, false, null, null,
                        "A hosts list blocking phishing sites. (Compressed, currently cannot be subscribed to/added.)",
                        null, null, "http://rlwpx.free.fr/WPFF/don.htm", "contact.wiki.airelle@spamgourmet.com",
                        "http://rlwpx.free.fr/Webforum/", "http://rlwpx.free.fr/WPFF/hosts.htm", null, (byte)5, null,
                        "Airelle's Phishing Hosts", null, null, null, null, "http://rlwpx.free.fr/WPFF/hblc.7z"
                    },
                    {
                        (ushort)183, false, null, null,
                        "Blocks shady, annoying pop-under ads from the infamous PopAds ad network.", null, null, null,
                        null, null, "https://github.com/Yhonay/antipopads",
                        "https://github.com/Yhonay/antipopads/issues", (byte)5, null, "Anti-PopAds", null, null, null,
                        null, "https://raw.githubusercontent.com/Yhonay/antipopads/master/popads.txt"
                    },
                    {
                        (ushort)182, false, null, null, "Complementary subscription to Liste FR + EasyList.",
                        "http://www.antipubfirefox.org/antipub/antipubfirefox-adblocklist-current-expanded.txt",
                        new DateTime(2017, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://www.antipubweb.org/", null, (byte)5, null, "AntiPubWeb", null, null, null, null,
                        "http://www.antipubfirefox.org/antipub/antipubfirefox-adblocklist-current-expanded.txt"
                    },
                    {
                        (ushort)181, false, null, null,
                        "A list for Adblock Plus, which is one of the most famous ad blocking softwares.",
                        "https://osdn.net/projects/ayucat-list/",
                        new DateTime(2009, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://osdn.net/projects/ayucat-list/", null, (byte)5, null, "Ayucat Powerful List", null,
                        null, null, null,
                        "http://git.sourceforge.jp/view?p=ayucat-list/ayucat-list.git;a=blob_plain;f=ayucat-list.txt;hb=b254c74c132832a3ade7b9d42c2ef8d3dd59fdb9"
                    },
                    {
                        (ushort)180, false, null, null,
                        "The sites listed there a fake/malicious sites that lure people with fake direct-download-links to JAV videos.",
                        null, null, null, null, "https://www.akiba-online.com/threads/fake-jav-ddl-sites-list.1560416/",
                        "https://www.akiba-online.com/threads/fake-jav-ddl-sites-list.1560416/", null, (byte)5, null,
                        "Bad JAV Sites", null, null, null, null, "https://pastebin.com/raw/kDqbYwWr"
                    }
                });

            migrationBuilder.InsertData(
                "filterlists",
                new[]
                {
                    "Id", "CantSnapshot", "ChatUrl", "CreatedDateUtc", "Description", "DescriptionSourceUrl",
                    "DiscontinuedDate", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId",
                    "ModifiedDateUtc", "Name", "PolicyUrl", "PublishedDate", "SubmissionUrl", "SyntaxId", "ViewUrl"
                },
                new object[,]
                {
                    {
                        (ushort)179, false, null, null,
                        "A non-comprehensive malware hosts list meant to be used in conjunction with the King of the PAC file.",
                        null, null, null, null, null, "https://www.hostsfile.org/hosts.html", null, (byte)5, null,
                        "BadHosts", null, null, null, null, "https://www.hostsfile.org/Downloads/hosts.txt"
                    },
                    {
                        (ushort)178, false, null, null,
                        "This is a list for blocking advertisements on the banki.ru site that are not blocked by \"conventional\" lists.",
                        "https://raw.githubusercontent.com/rebelion76/bankiru_plus_adblock_list/master/bankiru_plus.txt",
                        new DateTime(2016, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/rebelion76/bankiru_plus_adblock_list",
                        "https://github.com/rebelion76/bankiru_plus_adblock_list/issues", (byte)5, null,
                        "Banki.ru Plus Adblock List", null, null, null, null,
                        "https://raw.githubusercontent.com/rebelion76/bankiru_plus_adblock_list/master/bankiru_plus.txt"
                    },
                    {
                        (ushort)176, false, null, null,
                        "Adblock filters for both Adblock PLUS and uBlock. It also includes some anti-adblocking rules to make your adblocking extension undetectable. The author manually add the track block rules from https://better.fyi/trackers/ since those rules are only for an iOS app only.",
                        null, null, null, null, null, "https://github.com/anarki999/Adblock-List-Archive",
                        "https://github.com/anarki999/Adblock-List-Archive/issues", (byte)5, null,
                        "Better.fyi | Trackers (List)", null, null, null, null,
                        "https://raw.githubusercontent.com/anarki999/Adblock-List-Archive/master/Better.fyiTrackersBlocklist.txt"
                    },
                    {
                        (ushort)175, false, null, null,
                        "Adblock / Adblock plus filter list for blocking cookie notifications.",
                        "https://github.com/r4vi/block-the-eu-cookie-shit-list", null, null, null, null,
                        "https://github.com/r4vi/block-the-eu-cookie-shit-list",
                        "https://github.com/r4vi/block-the-eu-cookie-shit-list/issues", (byte)5, null,
                        "Block the EU Cookie Shit List", null, null, null, null,
                        "https://raw.githubusercontent.com/r4vi/block-the-eu-cookie-shit-list/master/filterlist.txt"
                    },
                    {
                        (ushort)174, false, null, null,
                        "Blockzilla is an optimized and slim list. Light on system resources yet still powerful against ads and trackers.",
                        "https://github.com/zpacman/Blockzilla", null, null, null, null,
                        "https://blockzilla.jimdo.com/", "https://github.com/zpacman/Blockzilla/issues", (byte)5, null,
                        "Blockzilla", null, null, null, null,
                        "https://raw.githubusercontent.com/zpacman/Blockzilla/master/Blockzilla.txt"
                    },
                    {
                        (ushort)173, false, null, null,
                        "A hosts list blocking miscellaneous annoyances. (Compressed, currently cannot be subscribed to/added.)",
                        null, null, "http://rlwpx.free.fr/WPFF/don.htm", "contact.wiki.airelle@spamgourmet.com",
                        "http://rlwpx.free.fr/Webforum/", "http://rlwpx.free.fr/WPFF/hosts.htm", null, (byte)5, null,
                        "Airelle's Anti-Miscellaneous Hosts", null, null, null, null,
                        "http://rlwpx.free.fr/WPFF/hmis.7z"
                    },
                    {
                        (ushort)171, false, null, null,
                        "This is a general, mainly a Finnish list for blocking various elements on specific websites such as ads, cookie notifications and cosmetic annoyances.",
                        "https://dl.dropboxusercontent.com/s/1ybzw9lb7m1qiyl/AAs.txt", null, null, null, null,
                        "https://dl.dropboxusercontent.com/s/1ybzw9lb7m1qiyl/AAs.txt", null, (byte)5, null,
                        "Additional Adblock Rules", null, null, null, null,
                        "https://dl.dropboxusercontent.com/s/1ybzw9lb7m1qiyl/AAs.txt"
                    },
                    {
                        (ushort)154, false, null, null,
                        "Use this file to prevent your computer from connecting to selected internet hosts. This is an easy and effective way to protect you from many types of spyware, reduces bandwidth use, blocks certain pop-up  traps, prevents user tracking by way of \"web bugs\" embedded in spam, provides partial protection to IE from certain web-based exploits and blocks most advertising you would otherwise be subjected to on the internet.",
                        "https://raw.githubusercontent.com/mozillahispano/nauscopio-filtros/master/hosts", null, null,
                        null, null,
                        "https://nauscopio.wordpress.com/2011/09/05/archivo-hosts-nauscopico-para-combatir-publicidad-paginas-peligrosas-contadores-de-visitas-spam-en-combinacion-con-los-filtros-nauscopicos/",
                        "https://github.com/mozillahispano/nauscopio-filtros/issues", (byte)5, null,
                        "Filtros Nauscopicos Hosts", null, null, null, null,
                        "https://raw.githubusercontent.com/mozillahispano/nauscopio-filtros/master/hosts"
                    },
                    {
                        (ushort)153, false, null, null, "Finnish blocklist for AdBlock to block social media stuff.",
                        "https://adb.juvander.net/Finland_adb_antisocial.txt", null, null, null, null, null, null,
                        (byte)5, null, "Finnish AntiSocial", null, null, null, null,
                        "https://adb.juvander.net/Finland_adb_antisocial.txt"
                    },
                    {
                        (ushort)152, false, null, null,
                        "Removes unnecessary elements from specific file sharing sites.",
                        "https://firime.wordpress.com/projects/others/fedlist/", null, null, null, null,
                        "https://firime.wordpress.com/projects/others/fedlist/", null, (byte)5, null,
                        "Firime (FED) EasyDownload List", null, null, null, null, "https://pastebin.com/raw/r9a5WrZa"
                    },
                    {
                        (ushort)151, false, null, null,
                        "Whitelists the trackers on the BarclayCard shopping portal so that rewards can be credited.",
                        null, null, null, null, null, null, null, (byte)5, null, "Shopping Whitelist BarclayCard", null,
                        null, null, null, "https://www.barclaycardrewardsboost.com/adBlockWhitelist.php"
                    },
                    {
                        (ushort)149, false, null, null, "Blocks spammers.", null,
                        new DateTime(2015, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "wstearns@pobox.com",
                        null, "http://www.sa-blacklist.stearns.org/sa-blacklist/", null, (byte)5, null, "SA-Blacklist",
                        null, null, null, null,
                        "http://www.sa-blacklist.stearns.org/sa-blacklist/sa-blacklist.current.domains"
                    },
                    {
                        (ushort)196, false, null, null,
                        "The Feodo Tracker Feodo BadIP Blocklist only contains IP addresses (IPv4) used as C&C communication channel by the Feodo Trojan version B. These IP addresses are usually servers rented by cybercriminals directly and used for the exclusive purpose of hosting a Feodo C&C server. Hence you should expect no legit traffic to those IP addresses. I highly recommend you to block/drop any traffic towards any Feodo C&C using the Feodo BadIP Blocklist. Please consider that this blocklist only contains IP addresses used by version B of the Feodo Trojan. C&C communication channels used by version A, version C and version D are not covered by this blocklist.",
                        "https://feodotracker.abuse.ch/blocklist/", null, null, "contactme@abuse.ch", null,
                        "https://feodotracker.abuse.ch/blocklist/", null, (byte)5, null,
                        "abuse.ch Feodo BadIP Blocklist", null, null, null, null,
                        "https://feodotracker.abuse.ch/blocklist/?download=badips"
                    },
                    {
                        (ushort)198, false, null, null,
                        "ABPindo is an affiliated filter list written by hermawan that specifically removes adverts on Indonesian language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, null, "https://forums.lanik.us/viewforum.php?f=94", "https://abpindo.blogspot.com/",
                        "https://github.com/ABPindo/indonesianadblockrules/issues", (byte)5, null, "ABPindo", null,
                        null, null, null,
                        "https://raw.githubusercontent.com/heradhis/indonesianadblockrules/master/subscriptions/abpindo.txt"
                    },
                    {
                        (ushort)199, false, null, null,
                        "Born from the need to block advertisements on the increasingly popular social network, this module is a great way to complete the protection offered by Adblock Plus and X Files during daily navigation. It may be associated with the main module of the X-Files or third-party lists.",
                        "https://github.com/gioxx/xfiles", null, "https://paypal.me/gioxx/5", null,
                        "https://abpxfiles.uservoice.com/", "https://xfiles.noads.it/",
                        "https://github.com/gioxx/xfiles/issues", (byte)5, null, "X Files: NoFacebookAds", null, null,
                        null, null, "https://raw.githubusercontent.com/gioxx/xfiles/master/facebook.txt"
                    },
                    {
                        (ushort)200, false, null, null,
                        "The module that serves to protect the user's navigation, seamlessly integrates to subscriptions already installed on your Adblock Plus.",
                        "https://github.com/gioxx/xfiles", null, "https://paypal.me/gioxx/5", null,
                        "https://abpxfiles.uservoice.com/", "https://xfiles.noads.it/",
                        "https://github.com/gioxx/xfiles/issues", (byte)5, null, "X Files: HWS Harmful WebSites", null,
                        null, null, null, "https://raw.githubusercontent.com/gioxx/xfiles/master/siteblock.txt"
                    },
                    {
                        (ushort)238, false, null, null,
                        "Members with ad blocking software may experience issues receiving Cash Back. If you have AdBlock, Adblock Plus or uBlock, you can add or subscribe to the Ebates Cash Back Shopping filter list.",
                        "https://www.ebates.com/help/troubleshooting.htm#abp", null, null, null, null,
                        "https://www.ebates.com/", null, (byte)5, null, "Ebates Cash Back Shopping", null, null, null,
                        null, "https://www.ebates.com/whitelist/ebates-cash-back-shopping.txt"
                    },
                    {
                        (ushort)22, false, null, null, "A combined domain blocklist for blocking ransomware.", null,
                        null, null, "rt-intel@abuse.ch", null, "https://ransomwaretracker.abuse.ch/blocklist/", null,
                        (byte)7, null, "Ransomware Tracker Domain Blocklist", null, null, null, (byte)2,
                        "https://ransomwaretracker.abuse.ch/downloads/RW_DOMBL.txt"
                    },
                    {
                        (ushort)234, false, null, null, "Block Facebook objects on non-Facebook websites",
                        "http://www.squirrelconspiracy.net/abp/facebook-privacy-list.txt",
                        new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null,
                        "fbprivacylist@squirrelconspiracy.net", null,
                        "http://www.squirrelconspiracy.net/abp/facebook-privacy-list.html", null, (byte)5, null,
                        "Facebook Privacy List", null, null, null, null,
                        "http://www.squirrelconspiracy.net/abp/facebook-privacy-list.txt"
                    },
                    {
                        (ushort)232, false, null, null,
                        "Targeting sites with Hoax, propanganda and clickbait (fake sites). Note: List doesn't include harmless spoof/satire sites like theonion.com.",
                        "https://raw.githubusercontent.com/ryanbr/fanboy-adblock/master/fake-news.txt", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW", null,
                        "https://forums.lanik.us/viewtopic.php?f=88&t=34971",
                        "https://github.com/ryanbr/fanboy-adblock", "https://github.com/ryanbr/fanboy-adblock/issues",
                        (byte)5, null, "Fake-News List", null, null, null, null,
                        "https://raw.githubusercontent.com/ryanbr/fanboy-adblock/master/fake-news.txt"
                    },
                    {
                        (ushort)231, false, null, null, "Hide text ads by CSS.",
                        "https://blogram.net/2010/04/23/adblock/",
                        new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://blogram.net/2010/04/23/adblock/", null, (byte)5, null,
                        "BLOGRAM Element Hiding Filter List for Japan", null, null, null, null,
                        "https://blogram.net/wp-content/uploads/easylist1.txt"
                    },
                    {
                        (ushort)230, false, null, null, "Block the DL itself of advertising.",
                        "https://blogram.net/2010/04/23/adblock/",
                        new DateTime(2014, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://blogram.net/2010/04/23/adblock/", null, (byte)5, null,
                        "BLOGRAM Basic Filter List for Japan", null, null, null, null,
                        "https://blogram.net/wp-content/uploads/easylist2.txt"
                    },
                    {
                        (ushort)228, false, null, null, "Ad blocking rules for Iranian/Persian websites.",
                        "https://github.com/farrokhi/adblock-iran", null, null, null, null,
                        "https://github.com/farrokhi/adblock-iran", "https://github.com/farrokhi/adblock-iran/issues",
                        (byte)5, null, "Adblock Iran", null, null, null, null,
                        "https://raw.githubusercontent.com/farrokhi/adblock-iran/master/filter.txt"
                    },
                    {
                        (ushort)226, false, null, null, "Blocking mobile ad providers and some analytics providers.",
                        "https://adaway.org/hosts.txt", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=dominik%40sufficientlysecure.org&lc=US&item_name=AdAway%20Donation&no_note=0&no_shipping=1&currency_code=EUR",
                        null, "https://forum.xda-developers.com/showthread.php?t=2190753", "https://adaway.org/",
                        "https://github.com/AdAway/AdAway/issues", (byte)5, null, "AdAway", null, null, null, null,
                        "https://adaway.org/hosts.txt"
                    },
                    {
                        (ushort)225, false, null, null, "Blocks Japanese regional advertisements and trackers.", null,
                        null, null, null, null, "https://logroid.blogspot.com/", null, (byte)5, null,
                        "AdAway Blocking Hosts File for Japan", null, null, null, null,
                        "https://sites.google.com/site/logroid/files/hosts.txt"
                    },
                    {
                        (ushort)222, false, null, null,
                        "A set of adblock filters to block advertisement in Persian websites.",
                        "https://github.com/SlashArash/adblockfa/", null, null, "slasharash@protonmail.com", null,
                        "https://github.com/SlashArash/adblockfa", "https://github.com/SlashArash/adblockfa/issues",
                        (byte)5, null, "AdBlockFarsi", null, null, null, null,
                        "https://raw.githubusercontent.com/SlashArash/adblockfa/master/adblockfa.txt"
                    },
                    {
                        (ushort)221, false, null, null, "Blocks Estonian regional advertisements and trackers.", null,
                        null, null, "adblock@gurud.ee", null, "http://gurud.ee/veeb/adblock", null, (byte)5, null,
                        "Adblock Filters by Gurud.ee", null, null, null, null, "http://gurud.ee/ab.txt"
                    },
                    {
                        (ushort)220, false, null, null, "Blocks Korean regional advertisements and trackers.", null,
                        new DateTime(2014, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://code.google.com/archive/p/adblock-korea/", null, (byte)5, null, "Adblock Korea", null,
                        null, null, null,
                        "https://web.archive.org/web/20160411115130if_/http://adblock-korea.googlecode.com:80/git/adblock-korea.txt"
                    },
                    {
                        (ushort)219, false, null, null, "Prevention behavior tracking by the site administrator.",
                        "https://blogram.net/2010/04/23/adblock/",
                        new DateTime(2014, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://blogram.net/2010/04/23/adblock/", null, (byte)5, null,
                        "BLOGRAM Analysis Block Filter List for Japan", null, null, null, null,
                        "https://blogram.net/wp-content/uploads/easylist3.txt"
                    },
                    {
                        (ushort)148, false, null, null,
                        "I make supplemental filters in Adblock Plus to block garbage on webpages not blocked by other lists. I use many regular expressions, a few domain filters, but no CSS filters.",
                        "https://satterly.neocities.org/abp_filters.html", null, null, null, null,
                        "https://satterly.neocities.org/abp_filters.html", null, (byte)5, null,
                        "Satterly's Adblock Plus Filters", null, null, null, null,
                        "https://satterly.neocities.org/abp_filters.txt"
                    },
                    {
                        (ushort)218, false, null, null, "Blocks Finnish regional advertisements and trackers.", null,
                        null, null, null,
                        "https://www.juvander.fi/site/ilpo/Forums/tabid/139/forumid/23/scope/threads/Default.aspx",
                        "https://www.juvander.fi/site/ilpo/Home/tabid/127/EntryId/825/New-Adblock-filter-list.aspx",
                        null, (byte)5, null, "Adblock List for Finland", null, null, null, null,
                        "https://adb.juvander.net/Finland_adb.txt"
                    },
                    {
                        (ushort)215, false, null, null,
                        "Adblock PL is official Poland filter list for AdBlock and Adblock Plus.",
                        "https://github.com/adblockpolska/Adblock_PL_List",
                        new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null,
                        "adblockpolska@gmail.com", null, "https://www.facebook.com/adblockpl",
                        "https://github.com/adblockpolska/Adblock_PL_List/issues", (byte)5, null, "Adblock Polska",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/adblockpolska/Adblock_PL_List/master/adblock_polska.txt"
                    },
                    {
                        (ushort)213, false, null, null, "Blocks ads on YouTube.", null, null, null, null, null,
                        "https://github.com/kbinani/adblock-youtube-ads", null, (byte)5, null, "Adblock YouTube Ads",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/kbinani/adblock-youtube-ads/master/signed.txt"
                    },
                    {
                        (ushort)212, false, null, null, "2o7Net tracking sites based on BadHosts content.",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues",
                        (byte)5, null, "add.2o7Net", null, null, null, null,
                        "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.2o7Net/hosts"
                    },
                    {
                        (ushort)211, false, null, null,
                        "This blocklists only includes IPv4 addresses that are used by the ZeuS trojan. It is the recommened blocklist if you want to block only ZeuS IPs. It excludes IP addresses that ZeuS Tracker believes to be hijacked (level 2) or belong to a free web hosting provider (level 3).",
                        "https://zeustracker.abuse.ch/blocklist.php", null, "https://zeustracker.abuse.ch/faq.php",
                        "contactme@abuse.ch", null, "https://zeustracker.abuse.ch/blocklist.php", null, (byte)5, null,
                        "abuse.ch ZeuS IP Blocklist \"BadIPs\"", null, null, null, null,
                        "https://zeustracker.abuse.ch/blocklist.php?download=badips"
                    },
                    {
                        (ushort)210, false, null, null,
                        "This blocklist contains all IPv4 addresses associated with ZeuS C&Cswhich are currently being tracked by ZeuS Tracker.",
                        "https://zeustracker.abuse.ch/blocklist.php", null, "https://zeustracker.abuse.ch/faq.php",
                        "contactme@abuse.ch", null, "https://zeustracker.abuse.ch/blocklist.php", null, (byte)5, null,
                        "abuse.ch ZeuS IP Blocklist", null, null, null, null,
                        "https://zeustracker.abuse.ch/blocklist.php?download=ipblocklist"
                    },
                    {
                        (ushort)209, false, null, null,
                        "The ZeuS domain blocklist (BadDomains) is the recommended blocklist if you want to block only ZeuS domain names. It excludes domain names that ZeuS Tracker believes to be hijacked (level 2).",
                        "https://zeustracker.abuse.ch/blocklist.php", null, "https://zeustracker.abuse.ch/faq.php",
                        "contactme@abuse.ch", null, "https://zeustracker.abuse.ch/blocklist.php", null, (byte)5, null,
                        "abuse.ch ZeuS Domain Blocklist \"BadDomains\"", null, null, null, null,
                        "https://zeustracker.abuse.ch/blocklist.php?download=baddomains"
                    },
                    {
                        (ushort)208, false, null, null,
                        "This blocklist contains all domain names associated with ZeuS C&Cs which are currently being tracked by ZeuS Tracker.",
                        "https://zeustracker.abuse.ch/blocklist.php", null, "https://zeustracker.abuse.ch/faq.php",
                        "contactme@abuse.ch", null, "https://zeustracker.abuse.ch/blocklist.php", null, (byte)5, null,
                        "abuse.ch ZeuS Domain Blocklist", null, null, null, null,
                        "https://zeustracker.abuse.ch/blocklist.php?download=domainblocklist"
                    },
                    {
                        (ushort)206, false, null, null,
                        "The ABP advertising filter is built with the mission of improving the browsing experience for the vietnamese users. ABPVN may not help block all ads, but ABPVN will minimize the appearance of ads on most websites in Vietnam.",
                        "https://abpvn.com", null, "https://abpvn.com/napthe", "support@abpvn.com",
                        "http://www.vn-zoom.com/f77/abp-bo-loc-quang-cao-cho-nguoi-viet-2856275.html",
                        "https://abpvn.com", null, (byte)5, null, "ABPVN List", null, null, null, null,
                        "https://raw.githubusercontent.com/abpvn/abpvn/master/filter/abpvn.txt"
                    },
                    {
                        (ushort)205, false, null, null,
                        "Blocks Japanese regional social network advertisements and trackers.", null, null, null, null,
                        null, "https://github.com/k2jp/abp-japanese-filters",
                        "https://github.com/k2jp/abp-japanese-filters/issues", (byte)5, null,
                        "ABP Japanese 3rd Party SNS Filters", null, null, null, null,
                        "https://raw.githubusercontent.com/k2jp/abp-japanese-filters/master/abpjf_3rd_party_sns.txt"
                    },
                    {
                        (ushort)204, false, null, null, "Blocks irritating elements on Japanese regional webpages.",
                        null, null, null, null, null, "https://github.com/k2jp/abp-japanese-filters",
                        "https://github.com/k2jp/abp-japanese-filters/issues", (byte)5, null,
                        "ABP Japanese Element-hiding Filters", null, null, null, null,
                        "https://raw.githubusercontent.com/k2jp/abp-japanese-filters/master/abpjf_element_hiding.txt"
                    },
                    {
                        (ushort)203, false, null, null, "Blocks Japanese regional advertisements and trackers.", null,
                        null, null, null, null, "https://github.com/k2jp/abp-japanese-filters",
                        "https://github.com/k2jp/abp-japanese-filters/issues", (byte)5, null, "ABP Japanese Filters",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/k2jp/abp-japanese-filters/master/abpjf.txt"
                    },
                    {
                        (ushort)202, false, null, null, "Blocks Japanese regional advertisements and trackers.", null,
                        null, null, null, null, "https://github.com/k2jp/abp-japanese-filters",
                        "https://github.com/k2jp/abp-japanese-filters/issues", (byte)5, null,
                        "ABP Japanese Paranoid Filters", null, null, null, null,
                        "https://raw.githubusercontent.com/k2jp/abp-japanese-filters/master/abpjf_paranoid.txt"
                    },
                    {
                        (ushort)201, false, null, null,
                        "Specific for Italian websites but with an eye also to the most visited international, is the main form and the list officially recognized (for Italy), perfectly compatible with AdBlock Plus.",
                        "https://github.com/gioxx/xfiles", null, "https://paypal.me/gioxx/5", null,
                        "https://abpxfiles.uservoice.com/", "https://xfiles.noads.it/",
                        "https://github.com/gioxx/xfiles/issues", (byte)5, null, "ABP X Files", null, null, null, null,
                        "https://raw.githubusercontent.com/gioxx/xfiles/master/filtri.txt"
                    },
                    {
                        (ushort)217, false, null, null, "Blocks Persian regional advertisements and trackers.", null,
                        null, null, null, "https://adblockplus.org/forum/viewtopic.php?f=2&t=7658",
                        "https://ideone.com/K452p", null, (byte)5, null, "Adblock Persian List", null, null, null, null,
                        "https://ideone.com/plain/K452p"
                    },
                    {
                        (ushort)242, false, null, null,
                        "EasyPrivacy is an optional supplementary filter list that completely removes all forms of tracking from the internet, including web bugs, tracking scripts and information collectors, thereby protecting your personal data.",
                        "https://easylist.to/", null, null, "easylist.subscription@gmail.com",
                        "https://forums.lanik.us/", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null, "EasyPrivacy", null, null, null,
                        null, "https://easylist.to/easylist/easyprivacy.txt"
                    },
                    {
                        (ushort)147, false, null, null,
                        "My list removes advertisements from all the leading Danish Websites: Ekstra Bladet, Jyllands Posten, Berlingske, TV / 2, Computerworld, Version2, etc.",
                        "https://henrik.schack.dk/adblock/", null, "https://www.paypal.me/schack", null, null,
                        "https://henrik.schack.dk/adblock/", null, (byte)5, null, "Schack's Adblock Plus List", null,
                        null, null, null, "https://adblock.dk/block.csv"
                    },
                    {
                        (ushort)145, false, null, null,
                        "Whitelists the trackers on the Alaska Airlines shopping portal so that rewards can be credited.",
                        null, null, null, null, null, null, null, (byte)5, null, "Shopping Whitelist Alaska Airlines",
                        null, null, null, null, "https://www.mileageplanshopping.com/adBlockWhitelist.php"
                    },
                    {
                        (ushort)62, false, null, null,
                        "This filter will mainly block affiliate advertising, behavioral advertising, tend embedded script will overload, blog parts.",
                        "https://qme.mydns.jp/adblock.html", null, null, null, null,
                        "https://qme.mydns.jp/adblock.html", null, (byte)5, null, "Japanese Site Adblock Filter ver 2",
                        null, null, null, null, "https://qme.mydns.jp/data/AdblockV2.txt"
                    },
                    {
                        (ushort)59, false, null, null,
                        "A filter list for Adblock which covers filters for Korean websites.",
                        "https://github.com/gfmaster/adblock-korea-contrib", null, null, null, null,
                        "https://github.com/gfmaster/adblock-korea-contrib",
                        "https://github.com/gfmaster/adblock-korea-contrib/issues", (byte)5, null,
                        "Korean Adblock List", null, null, null, null,
                        "https://raw.githubusercontent.com/gfmaster/adblock-korea-contrib/master/filter.txt"
                    },
                    {
                        (ushort)54, false, null, null, "Block ads with /etc/hosts.",
                        "http://adblock.gjtech.net/?format=adblock-plus", null, null, null, null,
                        "https://www.gjtech.net/", null, (byte)5, null, "G&J Hosts", null, null, null, null,
                        "http://adblock.gjtech.net/?format=adblock-plus"
                    },
                    {
                        (ushort)53, false, null, null, "Blocks Japanese regional mobile advertisements and trackers.",
                        null, null, null, null, null, "https://gmbk0.tumblr.com/", null, (byte)5, null,
                        "gmbk0's AdAway Hosts for Android", null, null, null, null,
                        "https://gmbksfilters.googlecode.com/hg/hosts_adonly.txt"
                    },
                    {
                        (ushort)52, false, null, null, "Block all well known privacy trackers.",
                        "https://gnuzilla.gnu.org/filters/blacklist.txt", null, null, "bug-gnuzilla@gnu.org", null,
                        null, null, (byte)5, null, "GNU Blacklist", null, null, null, null,
                        "https://gnuzilla.gnu.org/filters/blacklist.txt"
                    },
                    {
                        (ushort)51, false, null, null, "Filter for advertisements on Greek sites.",
                        "https://www.void.gr/kargig/blog/greek-adblock-plus-filter/", null, null, null, null,
                        "https://www.void.gr/kargig/blog/greek-adblock-plus-filter/",
                        "https://github.com/kargig/greek-adblockplus-filter/issues", (byte)5, null,
                        "Greek AdBlock Filter", null, null, null, null,
                        "https://raw.githubusercontent.com/kargig/greek-adblockplus-filter/master/void-gr-filters.txt"
                    },
                    {
                        (ushort)50, false, null, null,
                        "We will blacklist domains that fall into any of the following categories: scams/phishing/malware/malvertising/exploits - and other general threats.",
                        "https://www.hexxiumcreations.com/projects/malicious-domain-blocking/", null, null,
                        "support@hexxiumcreations.com", null,
                        "https://www.hexxiumcreations.com/projects/malicious-domain-blocking/",
                        "https://github.com/HexxiumCreations/threat-list/issues", (byte)5, null,
                        "Hexxium Creations Threat List", null, null, null, null,
                        "https://raw.githubusercontent.com/HexxiumCreations/threat-list/gh-pages/hexxiumthreatlist.txt"
                    },
                    {
                        (ushort)49, false, null, null, "Japanese ad servers hosts file.", null, null, null, null,
                        "http://potato.2ch.net/test/read.cgi/android/1450730522/",
                        "https://sites.google.com/site/hosts2ch/", null, (byte)5, null, "Hosts2ch", null, null, null,
                        null, "https://sites.google.com/site/hosts2ch/ja"
                    },
                    {
                        (ushort)48, false, null, null,
                        "hpHosts is a community managed and maintained hosts file that allows an additional layer of protection against access to ad, tracking and malicious websites.",
                        "https://www.hosts-file.net/", null, null, null, null, "https://www.hosts-file.net/", null,
                        (byte)5, null, "hpHosts", null, null, null, null,
                        "https://www.hosts-file.net/download/hosts.txt"
                    },
                    {
                        (ushort)39, false, null, null,
                        "Latvian List is an affiliated filter list written by anonymous74100 that specifically removes adverts on Latvian language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "latvian-list@googlegroups.com", "https://forums.lanik.us/viewforum.php?f=99",
                        "https://notabug.org/latvian-list/adblock-latvian", null, (byte)5, null, "Latvian List", null,
                        null, null, null,
                        "https://notabug.org/latvian-list/adblock-latvian/raw/master/lists/latvian-list.txt"
                    },
                    {
                        (ushort)38, false, null, null, "AdBlock list for blocking 'how i can help you?' widgets.",
                        "https://github.com/Rpsl/adblock-leadgenerator-list", null, null, null, null,
                        "https://github.com/Rpsl/adblock-leadgenerator-list",
                        "https://github.com/Rpsl/adblock-leadgenerator-list/issues", (byte)5, null, "Lead Generator",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/Rpsl/adblock-leadgenerator-list/master/list/list.txt"
                    },
                    {
                        (ushort)36, false, null, null,
                        "A personal filter list. Each host is either an ad, phishing, malicious, analytics, or clickbait.",
                        "https://github.com/genediazjr/nopelist", null, null, null, null,
                        "https://github.com/genediazjr/nopelist", "https://github.com/genediazjr/nopelist/issues",
                        (byte)5, null, "Nopelist", null, null, null, null,
                        "https://raw.githubusercontent.com/genediazjr/nopelist/master/nopelist.txt"
                    },
                    {
                        (ushort)35, false, null, null, "Blocks trackers.", null, null, null, null, null,
                        "https://github.com/quidsup/notrack", "https://github.com/quidsup/notrack/issues", (byte)5,
                        null, "NoTrack Blocklist", null, null, null, null,
                        "https://raw.githubusercontent.com/quidsup/notrack/master/trackers.txt"
                    },
                    {
                        (ushort)34, false, null, null,
                        "OpenPhish uses proprietary Artificial Intelligence algorithms to automatically identify zero-day phishing sites and provide comprehensive, actionable, real-time threat intelligence.",
                        "https://openphish.com/", null, null, "contact@openphish.com", null, "https://openphish.com/",
                        null, (byte)5, null, "OpenPhish Phishing Intelligence Community Feed", null, null, null, null,
                        "https://openphish.com/feed.txt"
                    },
                    {
                        (ushort)33, false, null, null,
                        "Adblock filter for obtrusive overlay (pop up) elements and various other annoying elements on websites.",
                        "https://github.com/LordBadmintonofYorkshire/Overlay-Blocker", null, null, null, null,
                        "https://github.com/LordBadmintonofYorkshire/Overlay-Blocker",
                        "https://github.com/LordBadmintonofYorkshire/Overlay-Blocker/issues", (byte)5, null,
                        "Overlay Blocker", null, null, null, null,
                        "https://raw.githubusercontent.com/LordBadmintonofYorkshire/Overlay-Blocker/master/blocklist.txt"
                    },
                    {
                        (ushort)32, false, null, null, "Block advertisements.", null, null, null, "pgl@yoyo.org", null,
                        "https://pgl.yoyo.org/adservers/", null, (byte)5, null, "Peter Lowe's List", null, null, null,
                        null,
                        "https://pgl.yoyo.org/adservers/serverlist.php?hostformat=adblockplus&showintro=1&mimetype=plaintext"
                    },
                    {
                        (ushort)31, false, null, null,
                        "Contains a list of elements of advertising, such as banners or flash animations, the most commonly used on Polish websites.",
                        "http://niecko.pl/adblock/", new DateTime(2011, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null, null, null, "http://niecko.pl/adblock/", null, (byte)5, null, "PLgeneral", null, null,
                        null, null, "https://www.niecko.pl/adblock/adblock.txt"
                    },
                    {
                        (ushort)29, false, null, null,
                        "Prebake is an Adblock filter subscription that blocks large, obtrusive cookie notices. These notices either consume a considerable amount of screen real estate or popup and distract the viewers attention, which can be just as annoying as ads.",
                        "http://prebake.eu/", new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null,
                        "cookies@prebake.eu", null, "http://prebake.eu/", "https://github.com/liamja/Prebake/issues",
                        (byte)5, null, "Prebake Obtrusive", null, null, null, null,
                        "https://raw.githubusercontent.com/liamja/Prebake/master/obtrusive.txt"
                    },
                    {
                        (ushort)28, false, null, null,
                        "The Quiet list blocks all other notices regardless of their size or obnoxiousness. Simple two- or three-word links to privacy pages aren't blocked (such as links in a page footer), but a lengthy paragraph mid-page will be.",
                        "https://github.com/liamja/Prebake",
                        new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cookies@prebake.eu",
                        null, "http://prebake.eu/", "https://github.com/liamja/Prebake/issues", (byte)5, null,
                        "Prebake Quiet", null, null, null, null,
                        "https://raw.githubusercontent.com/liamja/Prebake/master/quiet.txt"
                    },
                    {
                        (ushort)489, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Unified Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedUnified/energized/hosts"
                    },
                    {
                        (ushort)488, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Ultimate Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedUltimate/energized/hosts"
                    },
                    {
                        (ushort)487, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Porn Lite Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedPornLite/energized/hosts"
                    },
                    {
                        (ushort)486, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Lite Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedLite/energized/hosts"
                    },
                    {
                        (ushort)485, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Blu go", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedBlu/master/energized/blu_go"
                    },
                    {
                        (ushort)484, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null, "Energized Blu",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedBlu/master/energized/blu"
                    },
                    {
                        (ushort)483, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Porn Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedPorn/energized/hosts"
                    },
                    {
                        (ushort)482, false, null, null, null, null, null, null, "mail.energized@protonmail.com", null,
                        "https://ador.chorompotro.com/energized",
                        "https://github.com/EnergizedProtection/EnergizedHosts/issues", (byte)2, null,
                        "Energized Malware Protection", null, null, null, null,
                        "https://raw.githubusercontent.com/EnergizedProtection/EnergizedHosts/master/EnergizedMalware/energized/hosts"
                    },
                    {
                        (ushort)63, false, null, null,
                        "This filter will mainly block affiliate advertising, behavioral advertising, tend embedded script will overload, blog parts.",
                        "https://qme.mydns.jp/adblock.html", null, null, null, null,
                        "https://qme.mydns.jp/adblock.html", null, (byte)5, null, "Japanese Site Adblock Filter", null,
                        null, null, null, "https://qme.mydns.jp/data/Adblock.txt"
                    },
                    {
                        (ushort)64, false, null, null, "A list combining Malware Domain List and Spybot.", null,
                        new DateTime(2016, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null,
                        (byte)5, null, "Jansal's Hosts Light", null, null, null, null,
                        "https://raw.githubusercontent.com/lewisje/jansal/master/adblock/hostslt"
                    },
                    {
                        (ushort)65, false, null, null,
                        "A list combining Malware Domain List, Peter Lowe's List, Spybot, and Spyware Blaster.", null,
                        new DateTime(2016, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null,
                        (byte)5, null, "Jansal's Hosts", null, null, null, null,
                        "https://raw.githubusercontent.com/lewisje/jansal/master/adblock/hosts"
                    },
                    {
                        (ushort)66, false, null, null,
                        "My Adblock Plus filter subscription will block banner ads, flash ads, text-ads, and even completely block some rogue anti-virus and anti-spyware websites preventing infection.",
                        "https://www.jabcreations.com/web/adblock-subscription", null, null, null, null,
                        "https://www.jabcreations.com/web/adblock-subscription", null, (byte)5, null,
                        "JAB Creations' Adblock Plus Filter Subscription", null, null, null, null,
                        "https://www.jabcreations.com/downloads/adblock-filters.php"
                    },
                    {
                        (ushort)144, false, null, null,
                        "Whitelists the trackers on the American Airlines shopping portal so that rewards can be credited.",
                        null, null, null, null, null, null, null, (byte)5, null, "Shopping Whitelist American Airlines",
                        null, null, null, null, "https://www.aadvantageeshopping.com/adBlockWhitelist.php"
                    },
                    {
                        (ushort)143, false, null, null,
                        "Whitelists the trackers on the Southwest Airlines shopping portal so that rewards can be credited.",
                        null, null, null, null, null, null, null, (byte)5, null,
                        "Shopping Whitelist Southwest Airlines", null, null, null, null,
                        "https://rapidrewardsshopping.southwest.com/adBlockWhitelist.php"
                    },
                    {
                        (ushort)142, false, null, null, "Block ads with AdBlock filter.",
                        "http://adblock.gjtech.net/?format=unix-hosts", null, null, null, null,
                        "https://www.gjtech.net/", null, (byte)5, null, "G&J AdBlock", null, null, null, null,
                        "http://adblock.gjtech.net/?format=unix-hosts"
                    },
                    {
                        (ushort)141, false, null, null,
                        "Whitelists the trackers on the United Airlines shopping portal so that rewards can be credited.",
                        null, null, null, null, null, null, null, (byte)5, null, "Shopping Whitelist United Airlines",
                        null, null, null, null, "https://shopping.mileageplus.com/adBlockWhitelist.php"
                    },
                    {
                        (ushort)140, false, null, null,
                        "This filter protects you from online scams. This filter is regularly updated with data collected by Spam404.com.",
                        "https://raw.githubusercontent.com/Dawsey21/Lists/master/adblock-list.txt", null, null,
                        "admin@spam404.com", null,
                        "http://www.spam404.com/blog/block-online-scams-with-spam404-and-adblock",
                        "https://github.com/Dawsey21/Lists/issues", (byte)5, null, "Spam404", null, null, null, null,
                        "https://raw.githubusercontent.com/Dawsey21/Lists/master/adblock-list.txt"
                    },
                    {
                        (ushort)139, false, null, null,
                        "The Spam404 domain blacklist is a regularly updated list of abusive domain names.",
                        "http://www.spam404.com/domain-blacklist.html", null, null, "admin@spam404.com", null,
                        "http://www.spam404.com/domain-blacklist.html", "https://github.com/Dawsey21/Lists/issues",
                        (byte)5, null, "Spam404 Domain Blacklist", null, null, null, null,
                        "https://raw.githubusercontent.com/Dawsey21/Lists/master/main-blacklist.txt"
                    },
                    {
                        (ushort)138, false, null, null, "Streaming services ads sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues",
                        (byte)5, null, "StreamingAds", null, null, null, null,
                        "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/StreamingAds/hosts"
                    },
                    {
                        (ushort)136, false, null, null,
                        "SVN: Slovenian List is regional list primarily for uBlock Origin or uBlock, which consists mostly of static cosmetic filters and a few tracking filters. Among others, there are 100 most popular Slovenian websites included in this list.",
                        "https://github.com/betterwebleon/slovenian-list", null, null, "betterweb.leon@outlook.com",
                        null, "https://github.com/betterwebleon/slovenian-list",
                        "https://github.com/betterwebleon/slovenian-list/issues", (byte)5, null, "SVN: Slovenian List",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/betterwebleon/slovenian-list/master/filters.txt"
                    },
                    {
                        (ushort)135, false, null, null, "Blocks advertisements and trackers.", null, null, null,
                        "wduk10@hotmail.com", null, "https://hostsfile.mine.nu/", null, (byte)5, null,
                        "The Hosts File Project Adblock Filters", null, null, null, null,
                        "https://hostsfile.mine.nu/downloads/adblock.txt"
                    },
                    {
                        (ushort)132, false, null, null, "Blocks Russian regional advertisements and trackers.", null,
                        new DateTime(2008, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "denis-ovs@yandex.ru",
                        "https://forum.mozilla-russia.org/viewtopic.php?id=3679", "http://denis-ovs.narod.ru/", null,
                        (byte)5, null, "RU AdList [Old]", null, null, null, null,
                        "http://denis-ovs.narod.ru/adblock.txt"
                    },
                    {
                        (ushort)119, false, null, null, "Romanian ad block filtering list.",
                        "https://github.com/tcptomato/ROad-Block", null, null, "contact@adblock.ro",
                        "https://muut.com/i/adblockro/comments", "https://www.adblock.ro/",
                        "https://github.com/tcptomato/ROad-Block/issues", (byte)5, null, "ROad-Block", null, null, null,
                        null, "https://road.adblock.ro/lista.txt"
                    },
                    {
                        (ushort)118, false, null, null, "Romanian supplement for EasyList.",
                        "https://adblockplus.org/subscriptions", null, null, "mail@zoso.ro", null,
                        "https://www.zoso.ro/rolist/", null, (byte)5, null, "ROList", null, null, null, null,
                        "https://www.zoso.ro/pages/rolist.txt"
                    },
                    {
                        (ushort)116, false, null, null,
                        "This is a complementary list for RoList with annoyances that are not necessarly banners.",
                        "https://www.zoso.ro/pages/rolist2.txt", null, null, "mail@zoso.ro", null,
                        "https://www.zoso.ro/rolist/", null, (byte)5, null, "ROList2", null, null, null, null,
                        "https://www.zoso.ro/pages/rolist2.txt"
                    },
                    {
                        (ushort)146, false, null, null,
                        "Adblock Plus for Japan domestic and Japanese correspondence Universal Filter.",
                        "http://www.schuzak.jp/other/abp.html", null, null, null, null,
                        "http://www.schuzak.jp/other/abp.html", null, (byte)5, null, "Schuzak's Universal Filter", null,
                        null, null, null,
                        "https://web.archive.org/web/20121106002043if_/http://www.schuzak.jp:80/other/abp.conf"
                    },
                    {
                        (ushort)115, false, null, null,
                        "Web adverts can be simply blocked by using a specially formatted text file called a “Hosts” file which is a list myself and numerous others have painstakingly compiled to now over 60000 (verified) known banner advertising companies and providers along with hostile websites that have been discovered (popup providers, spyware, dialers ,scams etc). This file tells your computer to try to and access itself whenever a banner advert is requested from a server that is in its \"black\" list, but instead of contacting the advert server your computer tries to request itself, and as your machine doesn't contain any adverts (if you are not running a web server) nothing will be shown.",
                        "https://hostsfile.mine.nu/", null, null, "wduk10@hotmail.com", null,
                        "https://hostsfile.mine.nu/", null, (byte)5, null, "The Hosts File Project Hosts", null, null,
                        null, null, "https://hostsfile.mine.nu/hosts0.txt"
                    },
                    {
                        (ushort)113, false, null, null, "Blocks Japanese regional advertisements and trackers.", null,
                        null, null, null, null, "http://tofukko.r.ribbon.to/abp.html", null, (byte)5, null,
                        "Tofu Filter", null, null, null, null, "http://tofukko.r.ribbon.to/Adblock_Plus_list.txt"
                    },
                    {
                        (ushort)103, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Fakenews + Gambling + Porn + Social", null, null, null, null,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling-porn-social/hosts"
                    },
                    {
                        (ushort)102, false, null, null,
                        "Block annoying web elements and reclaim lost screen real estate to make the web more user friendly!",
                        "https://raw.githubusercontent.com/yourduskquibbles/webannoyances/master/ultralist.txt", null,
                        null, null, null, "https://github.com/yourduskquibbles/webannoyances",
                        "https://github.com/yourduskquibbles/webannoyances/issues", (byte)5, null,
                        "Web Annoyances Ultralist", null, null, null, null,
                        "https://raw.githubusercontent.com/yourduskquibbles/webannoyances/master/ultralist.txt"
                    },
                    {
                        (ushort)101, false, null, null, "Finnish supplement list for EasyList.",
                        "https://raw.githubusercontent.com/wiltteri/subscriptions/master/wiltteri.txt",
                        new DateTime(2015, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/wiltteri/subscriptions", null, (byte)5, null, "Wiltteri", null, null, null,
                        null, "https://raw.githubusercontent.com/wiltteri/subscriptions/master/wiltteri.txt"
                    },
                    {
                        (ushort)100, false, null, null, "Finnish supplement list for EasyList.",
                        "https://raw.githubusercontent.com/wiltteri/subscriptions/master/wiltteri-reborn.txt",
                        new DateTime(2015, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/wiltteri/subscriptions", null, (byte)5, null, "Wiltteri Reborn", null, null,
                        null, null,
                        "https://raw.githubusercontent.com/wiltteri/subscriptions/master/wiltteri-reborn.txt"
                    },
                    {
                        (ushort)99, false, null, null, "Blocks Korean regional advertisements and trackers.", null,
                        null, null, null, null, "https://github.com/yous/YousList",
                        "https://github.com/yous/YousList/issues", (byte)5, null, "YousList", null, null, null, null,
                        "https://raw.githubusercontent.com/yous/YousList/master/youslist.txt"
                    },
                    {
                        (ushort)81, false, null, null,
                        "Windows installers ads sources sites based on Unchecky content.",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues",
                        (byte)5, null, "UncheckyAds", null, null, null, null,
                        "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/UncheckyAds/hosts"
                    },
                    {
                        (ushort)72, false, null, null, "Blocks Hungarian regional advertisements and trackers.", null,
                        null, null, "hufilter.adblock@gmail.com", null, "https://github.com/szpeter80/hufilter/wiki",
                        "https://github.com/szpeter80/hufilter/issues", (byte)5, null, "hufilter", null, null, null,
                        null, "https://raw.githubusercontent.com/szpeter80/hufilter/master/hufilter.txt"
                    },
                    {
                        (ushort)71, false, null, null,
                        "Get rid of annoying cookie warnings from almost all 'infected' websites!",
                        "https://www.kiboke-studio.hr/i-dont-care-about-cookies/", null, null, "info@kiboke-studio.hr",
                        null, "https://www.kiboke-studio.hr/i-dont-care-about-cookies/", null, (byte)5, null,
                        "I Don't Care about Cookies", null, null, null, null,
                        "https://www.kiboke-studio.hr/i-dont-care-about-cookies/abp/"
                    },
                    {
                        (ushort)70, false, null, null,
                        "List of filters for Adblock Plus that block cookie notices on European websites.",
                        "https://github.com/Rudloff/adblock-imokwithcookies", null, null, null, null,
                        "https://github.com/Rudloff/adblock-imokwithcookies",
                        "https://github.com/Rudloff/adblock-imokwithcookies/issues", (byte)5, null,
                        "I'm OK with Cookies", null, null, null, null,
                        "https://raw.githubusercontent.com/Rudloff/adblock-imokwithcookies/master/filters.txt"
                    },
                    {
                        (ushort)69, false, null, null, "Adblock Plus list for Icelandic websites.",
                        "https://adblock.gardar.net/", null, null, "adblock@gardar.net", null,
                        "https://adblock.gardar.net/", null, (byte)5, null, "Icelandic ABP List", null, null, null,
                        null, "https://adblock.gardar.net/is.abp.txt"
                    },
                    {
                        (ushort)68, false, null, null,
                        "This filter list for AdBlock removes popup sections on sites that distracts from the main content.",
                        "https://ilyakatz.github.io/adblock_filters/", null, null, null, null,
                        "https://ilyakatz.github.io/adblock_filters/",
                        "https://github.com/ilyakatz/adblock_filters/issues", (byte)5, null,
                        "Ilyakatz's Additional Filters for Adblock", null, null, null, null,
                        "https://raw.githubusercontent.com/ilyakatz/adblock_filters/master/inpage_popups.txt"
                    },
                    {
                        (ushort)67, false, null, null, "Filter any site/subsite who's only purpose is to log your IP.",
                        "https://github.com/piperun/iploggerfilter", null, null, null, null,
                        "https://github.com/piperun/iploggerfilter", "https://github.com/piperun/iploggerfilter/issues",
                        (byte)5, null, "iploggerfilter", null, null, null, null,
                        "https://raw.githubusercontent.com/piperun/iploggerfilter/master/filterlist"
                    },
                    {
                        (ushort)114, false, null, null, "Blocks advertisements and trackers.", null,
                        new DateTime(2015, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/thoughtconverge/abf", null, (byte)5, null,
                        "Thoughtconverge's Custom AdBlock Filters", null, null, null, null,
                        "https://raw.githubusercontent.com/thoughtconverge/abf/master/abf.txt"
                    },
                    {
                        (ushort)245, false, null, null, "Help you to block ads in Thailand websites.",
                        "https://github.com/easylist-thailand/easylist-thailand", null, null, null, null,
                        "https://easylist-thailand.github.io/",
                        "https://github.com/easylist-thailand/easylist-thailand/issues", (byte)5, null,
                        "EasyList Thailand", null, null, null, null,
                        "https://raw.githubusercontent.com/easylist-thailand/easylist-thailand/master/subscription/easylist-thailand.txt"
                    },
                    {
                        (ushort)237, false, null, null, "Blocks Estonian regional advertisements and trackers.", null,
                        null, null, null, null, "https://adblock.ee/", null, (byte)5, null, "Eesti Custom Sites Filter",
                        null, null, null, null, "https://adblock.ee/list.php"
                    },
                    {
                        (ushort)252, false, null, null,
                        "Tentative hosts file for Italian sites created from Easylist Italy and ADB X Files.",
                        "https://filtri-dns.ga/filtri.txt", null, null, null, null, "https://filtri-dns.ga/", null,
                        (byte)5, null, "Filtri DNS", null, null, null, null, "https://filtri-dns.ga/filtri.txt"
                    },
                    {
                        (ushort)378, false, null, null, "A block list of malicious domains.",
                        "https://github.com/cb-software/CB-Malicious-Domains/blob/master/README.md", null, null, null,
                        null, "https://github.com/cb-software/CB-Malicious-Domains",
                        "https://github.com/cb-software/CB-Malicious-Domains/issues", (byte)2, null,
                        "CB Malicious Domains - Hosts", null,
                        new DateTime(2018, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1,
                        "https://raw.githubusercontent.com/cb-software/CB-Malicious-Domains/master/block_lists/hosts"
                    },
                    {
                        (ushort)362, false, null, null, "A hostslist to prevent browser mining only",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null,
                        "CoinBlocker Hosts List Browser", null,
                        new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/hosts_browser"
                    },
                    {
                        (ushort)361, false, null, null, "An additional hostslist for administrators",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null,
                        "CoinBlocker Hosts List Optional", null,
                        new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/hosts_optional"
                    },
                    {
                        (ushort)360, false, null, null, "A hostslist for administrators to prevent mining in networks",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists", null,
                        "https://www.amazon.de/hz/wishlist/ls/2DDEDPJU2996I?filter=unpurchased&language=en_GB&sort=priority&type=wishlist",
                        "zerodot1@bk.ru", null, "https://gitlab.com/ZeroDot1/CoinBlockerLists",
                        "https://gitlab.com/ZeroDot1/CoinBlockerLists/issues", (byte)4, null, "CoinBlocker Hosts List",
                        null, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1,
                        "https://zerodot1.gitlab.io/CoinBlockerLists/hosts"
                    },
                    {
                        (ushort)347, false, "https://discord.me/polskiefiltry", null,
                        "Polish hosts file for use in Pi-hole", null, null, "https://patronite.pl/polskiefiltry",
                        "errors@certyficate.it", null, "https://www.certyficate.it/",
                        "https://github.com/MajkiIT/polish-ads-filter/issues", (byte)9, null,
                        "Polish Filters for Pi-hole", null,
                        new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1,
                        "https://raw.githubusercontent.com/MajkiIT/polish-ads-filter/master/polish-pihole-filters/hostfile.txt"
                    },
                    {
                        (ushort)340, false, null, null,
                        "Redirector list intended for Chinese users, for Gmail, Instagram, Wikipedia, Yahoo, Telegram(WEB), Dropbox, Flipboard, Mage, Line, Pinterest, W3schools, Ingress, Twitch, SoundCloud, Xboxlive, WordPress, Tapatalk, Kobo, Vimeo, Nytimes, Issuu, Tor, DuckDuckGo, Imgur, Pcbeta…",
                        null, null, null, null, null, "https://github.com/Lerist/Go-Hosts",
                        "https://github.com/Lerist/Go-Hosts/issues", (byte)2, null, "Go Hosts", null, null, null,
                        (byte)1, "https://raw.githubusercontent.com/Lerist/Go-Hosts/master/hosts"
                    },
                    {
                        (ushort)339, false, null, null,
                        "Hosts file to block ads on Chinese and some international sites.", null, null, null, null,
                        null, "https://github.com/Lerist/Go-Hosts", "https://github.com/Lerist/Go-Hosts/issues",
                        (byte)2, null, "Go Hosts AD", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/Lerist/Go-Hosts/master/hosts-ad"
                    },
                    {
                        (ushort)338, false, null, null,
                        "Useful from any site It is a sharp meta-analysis that was born as a result of brushing up, collecting such files, eliminating all error syntax, saving waste, etc. It is a powerful file to prevent uprooting affiliates and magical advertisements.",
                        "https://cosmonote.blogspot.jp/2013/07/adaway-hosts-adfree-windows7-windows8.html",
                        new DateTime(2014, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://cosmonote.blogspot.jp/2013/07/adaway-hosts-adfree-windows7-windows8.html", null,
                        (byte)5, null, "Japan Ultimate", null, null, null, (byte)1,
                        "https://sites.google.com/site/cosmonoteshosts/hosts_Ultimate.txt"
                    },
                    {
                        (ushort)337, false, null, null,
                        "Advertisements on smartphones are versatile, there are many things too complicated. Several HOSTSs have been released to Adaway since the beginning, but this file was further integrated, sorted, deleted duplicates, and polished.",
                        "https://cosmonote.blogspot.jp/2013/07/adaway-hosts-adfree-windows7-windows8.html",
                        new DateTime(2014, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://cosmonote.blogspot.jp/2013/07/adaway-hosts-adfree-windows7-windows8.html", null,
                        (byte)5, null, "HOSTS for Adaway for Japan", null, null, null, (byte)1,
                        "https://sites.google.com/site/cosmonoteshosts/hosts_for_Adaway.txt"
                    },
                    {
                        (ushort)336, false, null, null,
                        "Amazon, Yahoo, Facebook , Twitter etc. It is a file created as a result of verifying and reducing connection failure as much as possible by making the filter mild. We also do not connect to tracking cookies or some malicious sites.",
                        "http://cosmonote.blogspot.jp/2013/07/adaway-hosts-adfree-windows7-windows8.html",
                        new DateTime(2014, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "http://cosmonote.blogspot.jp/2013/07/adaway-hosts-adfree-windows7-windows8.html", null,
                        (byte)5, null, "HOSTS for Windows PC for Japan", null, null, null, (byte)1,
                        "https://sites.google.com/site/cosmonoteshosts/hosts_for_Windows8.txt"
                    },
                    {
                        (ushort)335, false, null, null, "Hosts for Adaway. Block mainly on advertisements for mobile.",
                        "https://github.com/multiverse2011/adawaylist-jp/blob/master/README.md", null, null, null, null,
                        "https://github.com/multiverse2011/adawaylist-jp",
                        "https://github.com/multiverse2011/adawaylist-jp/issues", (byte)5, null, "Adawaylist JP", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/multiverse2011/adawaylist-jp/master/hosts"
                    },
                    {
                        (ushort)334, false, null, null, "Hosts file to avoid advertisement display on website.",
                        "https://warui.intaa.net/adhosts/", null, null, null, null, "https://warui.intaa.net/adhosts/",
                        null, (byte)5, null, "Warui Hosts", null, null,
                        "https://warui.intaa.net/adhosts/#fh5co-blog-section", (byte)1,
                        "https://warui.intaa.net/adhosts/hosts.txt"
                    },
                    {
                        (ushort)330, false, null, null,
                        "To block domains that known as cost-per-action (AOC/CPA) services in Thailand, aim to prevent additional costs (post-paid plan) or balance deduction (pre-paid plan) that caused by some nasty ads that auto subscribe SMS/MMS/WAP services.",
                        "https://github.com/kowith337/ThaiConsentHosts/blob/master/readme.md", null, null, null, null,
                        "https://github.com/kowith337/ThaiConsentHosts",
                        "https://github.com/kowith337/ThaiConsentHosts/issues", (byte)13, null, "ThaiConsentHosts",
                        null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/kowith337/ThaiConsentHosts/master/ThaiConsentHosts.txt"
                    },
                    {
                        (ushort)329, false, null, null, "A hosts file for Chinese websites.", null, null, null, null,
                        null, "https://github.com/vokins/yhosts", "https://github.com/vokins/yhosts/issues", (byte)1,
                        null, "Yhosts", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/vokins/yhosts/master/hosts.txt"
                    },
                    {
                        (ushort)325, false, null, null,
                        "Hosts file, filled with advertisers and other purveyors of worthless content.",
                        "https://github.com/bjornstar/hosts", null, null, "bjorn@bjornstar.com", null,
                        "https://github.com/bjornstar/hosts", "https://github.com/bjornstar/hosts/issues", (byte)11,
                        null, "Bjornstar's Hosts", null, null, null, (byte)1,
                        "https://github.com/bjornstar/hosts/blob/master/hosts"
                    },
                    {
                        (ushort)324, false, null, null, "A minimal adblocker for iOS.",
                        "https://github.com/arcetera/Minimal-Hosts-Blocker",
                        new DateTime(2015, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/arcetera/Minimal-Hosts-Blocker",
                        "https://github.com/arcetera/Minimal-Hosts-Blocker/issues", (byte)5, null,
                        "Minimal Hosts Blocker", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/arcetera/Minimal-Hosts-Blocker/master/etc/MinimalHostsBlocker/minimalhosts"
                    },
                    {
                        (ushort)320, false, null, null, "An expiremental hosts list for blocking YouTube video ads.",
                        null, null, null, "anudeep@protonmail.com", null,
                        "https://github.com/anudeepND/youtubeadsblacklist",
                        "https://github.com/anudeepND/youtubeadsblacklist/issues", (byte)14, null,
                        "YouTube Video Ads Blocklist Hosts", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/anudeepND/youtubeadsblacklist/master/hosts.txt"
                    },
                    {
                        (ushort)318, false, null, null, "Blocks crytocurrency miner hosts.", null, null, null,
                        "anudeep@protonmail.com", null, "https://github.com/anudeepND/blacklist",
                        "https://github.com/anudeepND/blacklist/issues", (byte)2, null, "CoinMiner", null, null, null,
                        (byte)1, "https://raw.githubusercontent.com/anudeepND/blacklist/master/CoinMiner.txt"
                    },
                    {
                        (ushort)317, false, null, null, "Host file to block ads, tracking and more!",
                        "https://raw.githubusercontent.com/anudeepND/blacklist/master/adservers.txt", null, null,
                        "anudeep@protonmail.com", null, "https://github.com/anudeepND/blacklist",
                        "https://github.com/anudeepND/blacklist/issues", (byte)2, null,
                        "Adserving and Tracking Domains", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/anudeepND/blacklist/master/adservers.txt"
                    },
                    {
                        (ushort)316, false, null, null, "Ad servers list to block ads on Turkish websites.",
                        "https://github.com/bkrucarci/turk-adlist", null, null, null, null,
                        "https://github.com/bkrucarci/turk-adlist", "https://github.com/bkrucarci/turk-adlist/issues",
                        (byte)12, null, "Turk-Adlist", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/bkrucarci/turk-adlist/master/hosts"
                    },
                    {
                        (ushort)309, false, null, null, "A merged hosts file from a variety of other lists.", null,
                        null, null, "badmojr@gmail.com",
                        "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360",
                        "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360",
                        null, (byte)5, null, "1Hosts", null, null, null, (byte)1, "https://1hosts.cf/"
                    },
                    {
                        (ushort)308, false, null, null, "A hosts list to stop cryptomining in your browser.", null,
                        null, null, null, null, "https://github.com/hoshsadiq/adblock-nocoin-list",
                        "https://github.com/hoshsadiq/adblock-nocoin-list/issues", (byte)2, null, "NoCoin Hosts", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/hoshsadiq/adblock-nocoin-list/master/hosts.txt"
                    },
                    {
                        (ushort)177, false, null, null,
                        "BarbBlock is a content blocking list with standalone browser extensions for Chrome and Firefox. It blacklists sites which have used DMCA takedowns to force removal from other content blocking lists. Such takedowns are categorically invalid, but they can be effective at intimidating small open-source projects into compliance.",
                        "https://github.com/paulgb/BarbBlock/blob/master/README.md", null, null, null, null,
                        "https://ssl.bblck.me/", "https://github.com/paulgb/BarbBlock/issues", (byte)2, null,
                        "BarbBlock", null, null, null, (byte)1, "https://ssl.bblck.me/blacklists/hosts-file.txt"
                    }
                });

            migrationBuilder.InsertData(
                "filterlists",
                new[]
                {
                    "Id", "CantSnapshot", "ChatUrl", "CreatedDateUtc", "Description", "DescriptionSourceUrl",
                    "DiscontinuedDate", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId",
                    "ModifiedDateUtc", "Name", "PolicyUrl", "PublishedDate", "SubmissionUrl", "SyntaxId", "ViewUrl"
                },
                new object[,]
                {
                    {
                        (ushort)137, false, null, null, "Hosts contributed by Steven Black.",
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/data/StevenBlack/hosts", null, null,
                        "steveb@stevenblack.com", null, "https://github.com/StevenBlack/hosts",
                        "https://github.com/StevenBlack/hosts/issues", (byte)5, null, "Steven Black's Hosts", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/data/StevenBlack/hosts"
                    },
                    {
                        (ushort)251, false, null, null,
                        "Blocks English and Spanish regional advertisements and trackers.", null, null, null, null,
                        null,
                        "https://nauscopio.wordpress.com/2010/07/05/filtrado-bloqueo-y-ocultacion-de-la-publicidad-en-google-chrome/",
                        "https://github.com/mozillahispano/nauscopio-filtros/issues", (byte)5, null,
                        "Filtros Nauscopicos", null, null, null, null,
                        "https://raw.githubusercontent.com/mozillahispano/nauscopio-filtros/master/filtros.txt"
                    },
                    {
                        (ushort)111, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Social", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/social/hosts"
                    },
                    {
                        (ushort)110, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Fakenews", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews/hosts"
                    },
                    {
                        (ushort)401, false, null, null,
                        "Blocks ads, fake sites, shock sites, malware hosts and trackers. This hostfile's aim is not to break any useful websites.",
                        null, null, null, null, null, "https://github.com/notracking/hosts-blocklists",
                        "https://github.com/notracking/hosts-blocklists/issues", (byte)5, null,
                        "notracking - Hostnames", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/notracking/hosts-blocklists/master/hostnames.txt"
                    },
                    {
                        (ushort)109, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Fakenews + Gambling", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling/hosts"
                    },
                    {
                        (ushort)421, false, null, null, "A host file generated from updated phishing site feeds.",
                        "https://gitlab.com/Kurobeats/phishing_hosts#phishing-site-hosts-generator", null,
                        "https://kurobeats.xyz/", null, null, "https://gitlab.com/Kurobeats/phishing_hosts",
                        "https://gitlab.com/Kurobeats/phishing_hosts/issues", (byte)19, null, "Phishing Hosts", null,
                        null, null, (byte)1, "https://gitlab.com/Kurobeats/phishing_hosts/raw/master/hosts"
                    },
                    {
                        (ushort)430, false, null, null,
                        "Blocks rogue websites and some ads on Norwegian sites. Intended for use only with hosts-specific tools; users of uBlock Origin and Nano Adblocker should preferably use the regular version of this list instead.",
                        null, null,
                        "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations",
                        "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt",
                        "https://github.com/DandelionSprout/adfilt/issues", (byte)10, null,
                        "Dandelion Sprout's Norwegian Filters for Tidier Websites (Hosts version)", null, null, null,
                        (byte)1,
                        "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList%20alternate%20versions/AdawayHosts"
                    },
                    {
                        (ushort)503, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null,
                        "AdZHosts Mac / Linux Social List", null, null, null, (byte)1,
                        "https://adzhosts.eu/hosts/adzhosts-as-mac-linux.txt"
                    },
                    {
                        (ushort)502, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null, "AdZHosts Android Social List",
                        null, null, null, (byte)1, "https://adzhosts.eu/hosts/adzhosts-as-android.txt"
                    },
                    {
                        (ushort)501, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null, "AdZHosts Windows Social List",
                        null, null, null, (byte)1, "https://adzhosts.eu/hosts/adzhosts-as-windows.txt"
                    },
                    {
                        (ushort)500, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null,
                        "AdZHosts AdGuard / uBlock Social List", null, null, null, (byte)1,
                        "https://adzhosts.eu/hosts/adzguard-as.txt"
                    },
                    {
                        (ushort)499, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null, "AdZHosts Android", null, null,
                        null, (byte)1, "https://adzhosts.eu/hosts/adzhosts-android.txt"
                    },
                    {
                        (ushort)498, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null, "AdZHosts Mac / Linux", null,
                        null, null, (byte)1, "https://adzhosts.eu/hosts/adzhosts-mac-linux.txt"
                    },
                    {
                        (ushort)497, false, null, null, null, null, null, "https://adzhosts.eu/index-en.php", null,
                        null, "https://adzhosts.eu/index-en.php", null, (byte)5, null, "AdZHosts Windows", null, null,
                        null, (byte)1, "https://adzhosts.eu/hosts/adzhosts-windows.txt"
                    },
                    {
                        (ushort)495, false, null, null,
                        "Utility for detecting phishing domains targeting Ethereum users.", null, null, null,
                        "hello@metamask.io", null, "https://github.com/MetaMask/eth-phishing-detect",
                        "https://github.com/MetaMask/eth-phishing-detect/issues", (byte)23, null, "ETH Phishing Detect",
                        null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/MetaMask/eth-phishing-detect/master/src/hosts.txt"
                    },
                    {
                        (ushort)494, false, null, null,
                        "This list of hosts is compiled from server logs on my own servers and forms the basis of the bad referrers domain lists for The Nginx Ultimate Bad Bot Blocker at https://github.com/mitchellkrogza/nginx-ultimate-bad-bot-blocker and the Apache Ultimate Bad Bot Blocker at https://github.com/mitchellkrogza/apache-ultimate-bad-bot-blocker",
                        null, null, "https://paypal.me/mitchellkrog/", "mitchellkrog@gmail.com", null,
                        "https://github.com/mitchellkrogza/Badd-Boyz-Hosts",
                        "https://github.com/mitchellkrogza/Badd-Boyz-Hosts/issues", (byte)2, null, "Badd Boyz Hosts",
                        null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/mitchellkrogza/Badd-Boyz-Hosts/master/hosts"
                    },
                    {
                        (ushort)493, false, null, null, null, null, null, null, null, null,
                        "https://github.com/mhxion/pornaway", "https://github.com/mhxion/pornaway/issues", (byte)2,
                        null, "PornAway blacklist (ads)", null, null, null, (byte)1,
                        "https://github.com/mhxion/pornaway/raw/master/hosts/porn_ads.txt"
                    },
                    {
                        (ushort)492, false, null, null, null, null, null, null, null, null,
                        "https://github.com/mhxion/pornaway", "https://github.com/mhxion/pornaway/issues", (byte)2,
                        null, "PornAway blacklist (sites)", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/mhxion/pornaway/master/hosts/porn_sites.txt"
                    },
                    {
                        (ushort)491, false, null, null,
                        "This is an endeavour to find all porn domains and compile them into a single hosts to allow for easy blocking of porn on your local machine or on a network.",
                        null, null, null, null, null, "https://github.com/Clefspeare13/pornhosts",
                        "https://github.com/Clefspeare13/pornhosts/issues", (byte)2, null, "pornhosts", null, null,
                        null, (byte)1, "https://github.com/Clefspeare13/pornhosts/raw/master/0.0.0.0/hosts"
                    },
                    {
                        (ushort)490, false, null, null, null, null, null, null, null, null,
                        "https://github.com/CyanideBrother/anti-pr0n",
                        "https://github.com/CyanideBrother/anti-pr0n/issues", (byte)5, null, "Anti-pr0n hosts", null,
                        null, null, (byte)1, "https://raw.githubusercontent.com/CyanideBrother/anti-pr0n/master/hosts"
                    },
                    {
                        (ushort)478, false, null, null, "Blocks access to international Google domains.", null, null,
                        null, "jmdugan_pubprofile_1522347973@biocontact.org", null,
                        "https://github.com/jmdugan/blocklists", "https://github.com/jmdugan/blocklists/issues",
                        (byte)5, null, "jmdugan Blocklists Google International", null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/google/localized"
                    },
                    {
                        (ushort)477, false, null, null, "Blocks access to utility Google domains.", null, null, null,
                        "jmdugan_pubprofile_1522347973@biocontact.org", null, "https://github.com/jmdugan/blocklists",
                        "https://github.com/jmdugan/blocklists/issues", (byte)5, null,
                        "jmdugan Blocklists Google Utility", null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/google/non_localized"
                    },
                    {
                        (ushort)476, false, null, null, "Blocks access to Microsoft domains.", null, null, null,
                        "jmdugan_pubprofile_1522347973@biocontact.org", null, "https://github.com/jmdugan/blocklists",
                        "https://github.com/jmdugan/blocklists/issues", (byte)5, null, "jmdugan Blocklists Microsoft",
                        null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/microsoft/all"
                    },
                    {
                        (ushort)475, false, null, null, "Blocks access to Mozilla tracking domains.", null, null, null,
                        "jmdugan_pubprofile_1522347973@biocontact.org", null, "https://github.com/jmdugan/blocklists",
                        "https://github.com/jmdugan/blocklists/issues", (byte)5, null, "jmdugan Blocklists Mozilla",
                        null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/mozilla/all.txt"
                    },
                    {
                        (ushort)474, false, null, null, "Blocks access to all Facebook domains.", null, null, null,
                        "jmdugan_pubprofile_1522347973@biocontact.org", null, "https://github.com/jmdugan/blocklists",
                        "https://github.com/jmdugan/blocklists/issues", (byte)5, null, "jmdugan Blocklists Facebook",
                        null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/facebook/all"
                    },
                    {
                        (ushort)473, false, null, null, "Blocks access to CloudFlare domains.", null, null, null,
                        "jmdugan_pubprofile_1522347973@biocontact.org", null, "https://github.com/jmdugan/blocklists",
                        "https://github.com/jmdugan/blocklists/issues", (byte)5, null, "jmdugan Blocklists CloudFlare",
                        null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/cloudflare/all"
                    },
                    {
                        (ushort)472, false, null, null, "Blocks access to Pinterest domains.", null, null, null,
                        "jmdugan_pubprofile_1522347973@biocontact.org", null, "https://github.com/jmdugan/blocklists",
                        "https://github.com/jmdugan/blocklists/issues", (byte)5, null, "jmdugan Blocklists Pinterest",
                        null, null, null, (byte)1,
                        "https://github.com/jmdugan/blocklists/raw/master/corporations/pinterest/all"
                    },
                    {
                        (ushort)461, false, null, null,
                        "Blocks Game Telemetry and other game specific 'unneeded' stuff.", null, null,
                        "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's Game HOSTS Filter List", null, null, null, (byte)1,
                        "https://github.com/CHEF-KOCH/CKs-FilterList/raw/master/HOSTS/CK's-Game-HOSTS-FilterList.txt"
                    },
                    {
                        (ushort)460, false, null, null,
                        "A comprehensive, all-in-one domain list for thorough blocking of trackers, pop-up ads, ads, unwanted cookies and faked pages.",
                        null, null, "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's Onion & I2P Filter List", null, null, null, (byte)1,
                        "https://github.com/CHEF-KOCH/CKs-FilterList/raw/master/I2P%20%26%20Onion/CK's-Onion-FilterList.txt"
                    },
                    {
                        (ushort)455, false, null, null,
                        "HOSTS file to block all known NSA / GCHQ / C.I.A. / F.B.I. spying servers.", null, null,
                        "https://github.com/CHEF-KOCH/Donations", "CHEF-KOCH@protonmail.com", null,
                        "https://github.com/CHEF-KOCH/CKs-FilterList",
                        "https://github.com/CHEF-KOCH/CKs-FilterList/issues", (byte)17, null,
                        "CHEF-KOCH's NSABlocklist FilterList", null, null, null, (byte)1,
                        "https://github.com/CHEF-KOCH/CKs-FilterList/raw/master/Corporations/NSABlocklist/CK's-NSABlocklist-FilterList.txt"
                    },
                    {
                        (ushort)451, false, null, null, null, null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CXF2HBWCMSZVL", null,
                        null, "https://github.com/crazy-max/WindowsSpyBlocker",
                        "https://github.com/crazy-max/WindowsSpyBlocker/issues", (byte)2, null,
                        "WindowsSpyBlocker Hosts Extra", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/crazy-max/WindowsSpyBlocker/master/data/hosts/extra.txt"
                    },
                    {
                        (ushort)450, false, null, null, "Blocks Windows updates.", null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CXF2HBWCMSZVL", null,
                        null, "https://github.com/crazy-max/WindowsSpyBlocker",
                        "https://github.com/crazy-max/WindowsSpyBlocker/issues", (byte)2, null,
                        "WindowsSpyBlocker Hosts Update", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/crazy-max/WindowsSpyBlocker/master/data/hosts/update.txt"
                    },
                    {
                        (ushort)449, false, null, null, null, null, null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CXF2HBWCMSZVL", null,
                        null, "https://github.com/crazy-max/WindowsSpyBlocker",
                        "https://github.com/crazy-max/WindowsSpyBlocker/issues", (byte)2, null,
                        "WindowsSpyBlocker Hosts Spy", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/crazy-max/WindowsSpyBlocker/master/data/hosts/spy.txt"
                    },
                    {
                        (ushort)435, false, null, null, "A redirector list for Chinese users.", null, null, null, null,
                        null, "https://github.com/googlehosts/hosts", "https://github.com/googlehosts/hosts/issues",
                        (byte)22, null, "Google Hosts", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/googlehosts/hosts/master/hosts-files/hosts"
                    },
                    {
                        (ushort)423, false, null, null, null, null, null,
                        "https://www.malekal.com/dons-pour-malekal-com/", null, null, "https://www.malekal.com", null,
                        (byte)5, null, "Malekal's Hosts", null, null, null, (byte)1,
                        "https://www.malekal.com/HOSTS_filtre/HOSTS.txt"
                    },
                    {
                        (ushort)108, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Fakenews + Porn",
                        null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-porn/hosts"
                    },
                    {
                        (ushort)112, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Porn", null, null,
                        null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/porn/hosts"
                    },
                    {
                        (ushort)106, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Fakenews + Gambling + Porn", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling-porn/hosts"
                    },
                    {
                        (ushort)107, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Fakenews + Social", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-social/hosts"
                    },
                    {
                        (ushort)15, false, null, null,
                        "A filter list that fixes filtration errors in an alternative way due to limitations of adblockers other than AdGuard or those using Webkit content blocker API.",
                        "https://raw.githubusercontent.com/SlowMemory/List-KR/master/unbreak.txt", null, null, null,
                        null, "https://list-kr.github.io/", "https://github.com/SlowMemory/List-KR/issues", (byte)8,
                        null, "List-KR Unbreak", null, null, "https://list-kr.github.io/form.html", null,
                        "https://raw.githubusercontent.com/SlowMemory/List-KR/master/unbreak.txt"
                    },
                    {
                        (ushort)507, false, null, null,
                        "EasyList is the primary filter list that removes most adverts from international web pages, including unwanted frames, images, and objects. It is the most popular list used by many ad blockers and forms the basis of over a dozen combination and supplementary filter lists.",
                        "https://easylist.to/", null, null, "easylist.subscription@gmail.com",
                        "https://forums.lanik.us/viewforum.php?f=23", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null, "EasyList TPL", null, null, null,
                        null, "https://easylist-msie.adblockplus.org/easylist.tpl"
                    },
                    {
                        (ushort)496, false, null, null, "MrThreats filter list that blocks confirmed phishing domains",
                        null, null, null, null, null, "https://github.com/MrThreat/Confirmed-Phish",
                        "https://github.com/MrThreat/Confirmed-Phish/issues", (byte)5, null,
                        "Confirmed Phishing Domains", null, null, null, null,
                        "https://raw.githubusercontent.com/MrThreat/Confirmed-Phish/master/phish.txt"
                    },
                    {
                        (ushort)471, false, null, null,
                        "An ipset made from blocklists that track attacks, during  about the last 48 hours. (includes: blocklist_de, dshield_1d, greensnow)",
                        null, null, null, "costa@tsaousis.gr", null, "https://iplists.firehol.org/", null, (byte)5,
                        null, "Firehol Level 2", null, null, null, null,
                        "https://github.com/firehol/blocklist-ipsets/raw/master/firehol_level2.netset"
                    },
                    {
                        (ushort)470, false, null, null,
                        "A firewall blacklist composed from IP lists, providing maximum protection with minimum false positives. Suitable for basic protection on all internet facing servers, routers and firewalls. (includes: bambenek_c2, dshield, feodo, fullbogons, spamhaus_drop, spamhaus_edrop, sslbl, zeus_badips, ransomware_rw)",
                        null, null, null, "costa@tsaousis.gr", null, "https://iplists.firehol.org/", null, (byte)5,
                        null, "Firehol Level 1", null, null, null, null,
                        "https://github.com/firehol/blocklist-ipsets/raw/master/firehol_level1.netset"
                    },
                    {
                        (ushort)304, false, null, null, "A list of Skype resolvers.", null, null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH Skype Resolvers", null, null,
                        null, null, "https://mirror1.malwaredomains.com/files/Skype-resolvers.txt"
                    },
                    {
                        (ushort)303, false, null, null, "This is a list of URL shorteners.",
                        "https://mirror1.malwaredomains.com/files/url_shorteners.txt", null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH URL Shorteners", null, null,
                        null, null, "https://mirror1.malwaredomains.com/files/url_shorteners.txt"
                    },
                    {
                        (ushort)302, false, null, null,
                        "This list summarizes the top 20 attacking class C (/24) subnets over the last three days. The number of 'attacks' indicates the number of targets reporting scans from this subnet.",
                        "https://feeds.dshield.org/block.txt", null, null, "info@dshield.org", null,
                        "https://www.dshield.org/xml.html", null, (byte)5, null, "DShield.org Recommended Block List",
                        null, null, null, null, "https://feeds.dshield.org/block.txt"
                    },
                    {
                        (ushort)301, false, null, null,
                        "EasyList is the primary filter list that removes most adverts from international web pages, including unwanted frames, images, and objects. It is the most popular list used by many ad blockers and forms the basis of over a dozen combination and supplementary filter lists.",
                        "https://easylist.to/", null, null, "easylist.subscription@gmail.com",
                        "https://forums.lanik.us/viewforum.php?f=23", "https://easylist.to/",
                        "https://github.com/easylist/easylist/issues", (byte)5, null, "EasyList", null, null, null,
                        null, "https://easylist.to/easylist/easylist.txt"
                    },
                    {
                        (ushort)298, false, null, null, "Chinese supplement for the EasyList filters on IT sites.",
                        null, new DateTime(2015, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/nfer/easylistchina_it", "https://github.com/nfer/easylistchina_it/issues",
                        (byte)5, null, "EasyList China in IT", null, null, null, null,
                        "https://raw.githubusercontent.com/nfer/easylistchina_it/master/easylistchina_it.txt"
                    },
                    {
                        (ushort)296, false, null, null, "Low spec for equipment extremists blocked.",
                        "https://blogram.net/2010/04/23/adblock/",
                        new DateTime(2014, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://blogram.net/2010/04/23/adblock/", null, (byte)5, null,
                        "BLOGRAM Blog Parts Filter List for Japan", null, null, null, null,
                        "https://blogram.net/wp-content/uploads/easylist4.txt"
                    },
                    {
                        (ushort)291, false, null, null,
                        "EasyList Hebrew is an [EasyList] affiliated filter list written by BsT that specifically removes adverts on Hebrew language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "easylisthebrew@gmail.com", null, "https://github.com/easylist/EasyListHebrew",
                        "https://github.com/easylist/EasyListHebrew/issues", (byte)5, null, "EasyList Hebrew", null,
                        null, null, null,
                        "https://raw.githubusercontent.com/easylist/EasyListHebrew/master/EasyListHebrew.txt"
                    },
                    {
                        (ushort)288, false, null, null, "This is a list of long-lived, \"immortal,\" malware domains.",
                        "https://mirror1.malwaredomains.com/files/immortal_domains.txt", null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH Malware Domains Immortal", null,
                        null, null, null, "https://mirror1.malwaredomains.com/files/immortal_domains.txt"
                    },
                    {
                        (ushort)287, false, null, null, "This is a list of malware domains.", null, null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH Malware Domains", null, null,
                        null, null, "https://mirror1.malwaredomains.com/files/justdomains"
                    },
                    {
                        (ushort)286, false, null, null, "This is a list of free web hosting services.",
                        "https://mirror1.malwaredomains.com/files/freewebhosts.txt", null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH Free Web Hosts", null, null,
                        null, null, "https://mirror1.malwaredomains.com/files/freewebhosts.txt"
                    },
                    {
                        (ushort)285, false, null, null, "This is a list of dynamic DNS providers.",
                        "https://mirror1.malwaredomains.com/files/dynamic_dns.txt", null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH Dynamic DNS", null, null, null,
                        null, "https://mirror1.malwaredomains.com/files/dynamic_dns.txt"
                    },
                    {
                        (ushort)284, false, null, null,
                        "On this page you can find updated lists to block unwanted content in your favorite browser. With their help, the pesky ads that some sites terrorizing customers will be hidden.",
                        "https://stanev.org/abp/", null, null, "alex@stanev.org", null, "https://stanev.org/abp/", null,
                        (byte)5, null, "Bulgarian List", null, null, null, null, "https://stanev.org/abp/adblock_bg.txt"
                    },
                    {
                        (ushort)282, false, null, null,
                        "CAMELEON is a free system that helps Internet users or administrators to blocks web-adverts.",
                        "http://sysctl.org/cameleon/", null, null, "philippe@sysctl.org", null,
                        "http://sysctl.org/cameleon/", null, (byte)5, null, "CAMELEON Hosts", null, null, null, null,
                        "http://sysctl.org/cameleon/hosts"
                    },
                    {
                        (ushort)281, false, null, null,
                        "Removes annoyances, self-promotion and privacy protection on Chinese websites.",
                        "https://raw.githubusercontent.com/cjx82630/cjxlist/master/cjx-annoyance.txt", null, null,
                        "cjxlist@gmail.com", "https://abpchina.org/forum/forum.php",
                        "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667",
                        "https://github.com/cjx82630/cjxlist/issues", (byte)5, null, "CJX's Annoyance List", null, null,
                        null, null, "https://raw.githubusercontent.com/cjx82630/cjxlist/master/cjx-annoyance.txt"
                    },
                    {
                        (ushort)280, false, null, null,
                        "Clickbait Blocklist just blocks the most annoying clickbait ads. I don't mind ads; I just don't want clickbait crap about shocking celebrity photos and \"deep searches\" for local singles.",
                        "https://github.com/cpeterso/clickbait-blocklist/", null, null, null, null,
                        "https://github.com/cpeterso/clickbait-blocklist/", null, (byte)5, null, "Clickbait Blocklist",
                        null, null, null, null,
                        "https://raw.githubusercontent.com/cpeterso/clickbait-blocklist/master/clickbait-blocklist.txt"
                    },
                    {
                        (ushort)279, false, null, null,
                        "EFF maintains a Privacy Badger \"yellowlist\" of domains for which requests are allowed but Privacy Badger restricts access or availability of objectionable cookies and potentially other objectionable identifiers.",
                        "https://github.com/EFForg/privacybadgerchrome/blob/master/doc/yellowlist-criteria.md", null,
                        "https://supporters.eff.org/donate/support-privacy-badger", null, null,
                        "https://www.eff.org/privacybadger", "https://github.com/EFForg/privacybadgerfirefox/issues",
                        (byte)5, null, "Cookie Blocklist", null, null, null, null,
                        "https://www.eff.org/files/cookieblocklist.txt"
                    },
                    {
                        (ushort)278, false, null, null,
                        "Corset is a subscription filter to block intruding ads on sites using Korean.",
                        "https://code.google.com/archive/p/abp-corset/",
                        new DateTime(2011, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "corset@tistory.com",
                        null, "http://corset.tistory.com/", null, (byte)5, null, "Corset", null, null, null, null,
                        "https://web.archive.org/web/20110212174029if_/http://abp-corset.googlecode.com:80/hg/corset.txt"
                    },
                    {
                        (ushort)277, false, null, null, "Czech filters for Adblock Plus.",
                        "http://adblock.dajbych.net/adblock.txt",
                        new DateTime(2014, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "http://adblock.dajbych.net/", null, (byte)5, null, "Czech Filters for AdBlock", null, null,
                        null, null, "http://adblock.dajbych.net/adblock.txt"
                    },
                    {
                        (ushort)276, false, null, null,
                        "Use this file to prevent your computer from connecting to selected internet hosts. This is an easy and effective way to protect you from many types of spyware, reduces bandwidth use, blocks certain pop-up traps, prevents user tracking by way of \"web bugs\" embedded in spam, provides partial protection to IE from certain web-based exploits and blocks most advertising you would otherwise be subjected to on the internet.",
                        "https://someonewhocares.org/hosts/", null, null, "hosts@someonewhocares.org", null,
                        "https://someonewhocares.org/hosts/", null, (byte)5, null, "Dan Pollock's Hosts", null, null,
                        null, null, "https://someonewhocares.org/hosts/zero/hosts"
                    },
                    {
                        (ushort)270, false, null, null,
                        "This is a list of free/bulk domain registration services, who register 2nd level domains for free or almost free.",
                        "https://mirror1.malwaredomains.com/files/bulk_registrars.txt", null,
                        "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null,
                        "https://www.malwaredomains.com/", null, (byte)5, null, "DNS-BH Bulk Registrars", null, null,
                        null, null, "https://mirror1.malwaredomains.com/files/bulk_registrars.txt"
                    },
                    {
                        (ushort)268, false, null, null,
                        "This is a lite version of EasyList. Only for Simplified Chinese language websites.",
                        "https://raw.githubusercontent.com/cjx82630/cjxlist/master/cjxlist.txt", null, null,
                        "cjxlist@gmail.com", "https://abpchina.org/forum/forum.php",
                        "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667",
                        "https://github.com/cjx82630/cjxlist/issues", (byte)5, null, "EasyList Lite China", null, null,
                        null, null, "https://raw.githubusercontent.com/cjx82630/cjxlist/master/cjxlist.txt"
                    },
                    {
                        (ushort)267, false, null, null,
                        "EasyList Lithuania is an affiliated filter list written by gymka that specifically removes adverts on Lithuanian language websites.",
                        "https://easylist.to/pages/other-supplementary-filter-lists-and-easylist-variants.html", null,
                        null, "algimantas@margevicius.lt", "https://forums.lanik.us/viewforum.php?f=101",
                        "https://margevicius.lt/easylist_lithuania/", null, (byte)5, null, "EasyList Lithuania", null,
                        null, null, null, "https://margevicius.lt/easylistlithuania.txt"
                    },
                    {
                        (ushort)253, false, null, null,
                        "This filter list for uBlock Origin/Adblock Plus is designed to be used with such lists as EasyList, RU AdList etc., so it's substantially free of intersections with them. The list is made for blocking ad (mostly on Russian websites) missed by other filter lists maintainers. It is regularly updated and actively developed for now.",
                        "https://github.com/hant0508/uBlock-filters", null, null, "hant0508@gmail.com", null,
                        "https://github.com/hant0508/uBlock-filters",
                        "https://github.com/hant0508/uBlock-filters/issues", (byte)5, null, "Filters by hant0508", null,
                        null, null, null, "https://raw.githubusercontent.com/hant0508/uBlock-filters/master/filters.txt"
                    },
                    {
                        (ushort)437, false, null, null, "Complementary subscription to EasyList.",
                        "https://github.com/easylistbrasil/easylistbrasil/", null, null,
                        "easylistbrasil.subscription@gmail.com", "http://easylistbrasil.freeforums.net",
                        "https://easylistbrasil.github.io/", "https://github.com/easylistbrasil/easylistbrasil/issues",
                        (byte)8, null, "EasyList Brasil", null, null, null, null,
                        "https://raw.githubusercontent.com/easylistbrasil/easylistbrasil/filtro/easylistbrasil.txt"
                    },
                    {
                        (ushort)168, false, null, null,
                        "A filter composed from several other filters (English filter, Social media filter, Spyware filter, Mobile ads filter, EasyList and EasyPrivacy) and simplified specifically to be better compatible with DNS-level ad blocking. This filter is used by AdGuard DNS servers to block ads.",
                        "https://kb.adguard.com/en/general/adguard-ad-filters#simplified-domain-names-filter", null,
                        null, null, null, "https://github.com/AdguardTeam/AdguardDNS",
                        "https://github.com/AdguardTeam/AdguardDNS/issues", (byte)12, null,
                        "AdGuard Simplified Domain Names Filter",
                        "https://kb.adguard.com/en/general/adguard-filter-policy", null, null, null,
                        "https://filters.adtidy.org/windows/filters/15.txt"
                    },
                    {
                        (ushort)60, false, null, null, "Polish hosts file for blocking scams (Experimental).", null,
                        null, null, "kadrep@outlook.com", null, "https://azet12.github.io/KAD/",
                        "https://github.com/azet12/KAD/issues", (byte)8, null, "KAD Hosts File", null, null,
                        "https://azet12.github.io/KAD/informacje.html#form1-35", null,
                        "https://raw.githubusercontent.com/azet12/KADhosts/master/KADhosts.txt"
                    },
                    {
                        (ushort)4, false, null, null,
                        "Hosts file blocking known malware, spyware, virus, and shock sites",
                        "https://github.com/michaeltrimm/hosts-blocking",
                        new DateTime(2016, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null,
                        "https://github.com/michaeltrimm/hosts-blocking",
                        "https://github.com/michaeltrimm/hosts-blocking/issues", (byte)2, null, "Hosts Blocking", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/michaeltrimm/hosts-blocking/master/_hosts.txt"
                    },
                    {
                        (ushort)105, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Fakenews + Gambling + Social", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling-social/hosts"
                    },
                    {
                        (ushort)104, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Fakenews + Porn + Social", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-porn-social/hosts"
                    },
                    {
                        (ushort)96, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Porn + Social",
                        null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/porn-social/hosts"
                    },
                    {
                        (ushort)95, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Gambling + Social", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/gambling-social/hosts"
                    },
                    {
                        (ushort)93, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null,
                        "Unified Hosts + Gambling + Porn + Social", null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/gambling-porn-social/hosts"
                    },
                    {
                        (ushort)80, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts", null, null, null,
                        (byte)1, "https://raw.githubusercontent.com/StevenBlack/hosts/master/hosts"
                    },
                    {
                        (ushort)79, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Gambling", null,
                        null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/gambling/hosts"
                    },
                    {
                        (ushort)78, false, null, null,
                        "Extending and consolidating hosts files from a variety of sources",
                        "https://github.com/StevenBlack/hosts", null, null, null, null,
                        "https://github.com/StevenBlack/hosts", null, (byte)5, null, "Unified Hosts + Gambling + Porn",
                        null, null, null, (byte)1,
                        "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/gambling-porn/hosts"
                    },
                    {
                        (ushort)3, false, null, null,
                        "Hosts file to block advertisements and trackers designed for Android", null, null, null, null,
                        "https://forum.xda-developers.com/showthread.php?t=1916098",
                        "https://forum.xda-developers.com/showthread.php?t=1916098", null, (byte)3, null,
                        "MoaAB: Mother of All AD-BLOCKING", null, null, null, (byte)1, "https://adblock.mahakala.is/"
                    },
                    {
                        (ushort)73, false, null, null,
                        "Sites engaged in the selling, distribution or provision of warez (including but not limited to keygens, serials etc), where such provisions do not contain malware.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts WRZ", null, null, null, (byte)1,
                        "https://hosts-file.net/wrz.txt"
                    },
                    {
                        (ushort)58, false, null, null,
                        "Sites engaged in the distribution of Potentially Unwanted Programs.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts PUP", null, null, null, (byte)1,
                        "https://hosts-file.net/pup.txt"
                    },
                    {
                        (ushort)57, false, null, null, "Sites engaged in illegal pharmacy activities.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts PHA", null, null, null, (byte)1,
                        "https://hosts-file.net/pha.txt"
                    },
                    {
                        (ushort)55, false, null, null,
                        "The following hosts were added to hpHosts AFTER the last full release.",
                        "https://hosts-file.net/hphosts-partial.txt", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts Partial", null, null, null, (byte)1,
                        "https://hosts-file.net/hphosts-partial.txt"
                    },
                    {
                        (ushort)74, false, null, null, "Sites engaged in Phishing.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts PSH", null, null, null, (byte)1,
                        "https://hosts-file.net/psh.txt"
                    },
                    {
                        (ushort)398, false, null, null, null, null, null, null, null, null,
                        "https://jspenguin2017.github.io/uBlockProtector/",
                        "https://jspenguin2017.github.io/uBlockProtector/issues", (byte)4, null,
                        "Nano filters - Annoyance", null, null, null, (byte)12,
                        "https://cdn.rawgit.com/NanoAdblocker/NanoFilters/master/NanoFilters/NanoAnnoyance.txt"
                    },
                    {
                        (ushort)46, false, null, null, "Sites engaged in malware distribution.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts EMD", null, null, null, (byte)1,
                        "https://hosts-file.net/emd.txt"
                    },
                    {
                        (ushort)45, false, null, null,
                        "Sites engaged in the housing, development or distribution of exploits, including but not limited to exploitation of browser, software (inclusive of website software such as CMS), operating system exploits aswell as those engaged in exploits via social engineering.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts EXP", null, null, null, (byte)1,
                        "https://hosts-file.net/exp.txt"
                    },
                    {
                        (ushort)44, false, null, null,
                        "Sites engaged in the selling or distribution of bogus or fraudulent applications and/or provision of fraudulent services.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts FSA", null, null, null, (byte)1,
                        "https://hosts-file.net/fsa.txt"
                    },
                    {
                        (ushort)43, false, null, null,
                        "Sites engaged in astroturfing (otherwise known as grass roots marketing) or spamming.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts GRM", null, null, null, (byte)1,
                        "https://hosts-file.net/grm.txt"
                    },
                    {
                        (ushort)10, false, null, null, "A hosts list of domains serving malware", null, null, null,
                        null, "https://www.malwaredomainlist.com/forums/", "https://www.malwaredomainlist.com/", null,
                        (byte)7, null, "Malware Domain Hosts List", null, null,
                        "https://www.malwaredomainlist.com/contact.php", (byte)1,
                        "https://www.malwaredomainlist.com/hostslist/hosts.txt"
                    },
                    {
                        (ushort)17, false, null, null,
                        "Block ads, banners, 3rd party Cookies, 3rd party page counters, web bugs, and even most hijackers and possibly unwanted programs.",
                        "http://winhelp2002.mvps.org/hosts.htm", null,
                        "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UNHL2VY85PB8N",
                        "winhelp2002@gmail.com", null, "http://winhelp2002.mvps.org/", null, (byte)9, null,
                        "MVPS HOSTS", null, null, null, (byte)1, "http://winhelp2002.mvps.org/hosts.txt"
                    },
                    {
                        (ushort)47, false, null, null,
                        "This classification is assigned for domains being used for advert or tracking purposes.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts ATS", null, null, null, (byte)1,
                        "https://hosts-file.net/ad_servers.txt"
                    },
                    {
                        (ushort)42, false, null, null,
                        "Special classification for persons caught spamming the hpHosts forums.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts HFS", null, null, null, (byte)1,
                        "https://hosts-file.net/hfs.txt"
                    },
                    {
                        (ushort)41, false, null, null,
                        "Sites engaged in browser hijacking or other forms of hijacking (OS services, bandwidth, DNS, etc.).",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts HJK", null, null, null, (byte)1,
                        "https://hosts-file.net/hjk.txt"
                    },
                    {
                        (ushort)40, false, null, null, "Sites engaged in the use of misleading marketing tactics.",
                        "https://hosts-file.net/?s=classifications", null, null, null, "https://forum.hosts-file.net/",
                        "https://hosts-file.net/", null, (byte)5, null, "hpHosts MMT", null, null, null, (byte)1,
                        "https://hosts-file.net/mmt.txt"
                    }
                });

            migrationBuilder.InsertData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId", "CreatedDateUtc"},
                new object[,]
                {
                    {(byte)1, (byte)12, null},
                    {(byte)11, (byte)10, null},
                    {(byte)1, (byte)11, null},
                    {(byte)1, (byte)7, null},
                    {(byte)3, (byte)6, null},
                    {(byte)2, (byte)9, null},
                    {(byte)2, (byte)8, null},
                    {(byte)3, (byte)2, null},
                    {(byte)4, (byte)5, null},
                    {(byte)4, (byte)1, null},
                    {(byte)3, (byte)4, null},
                    {(byte)6, (byte)3, null}
                });

            migrationBuilder.InsertData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId", "CreatedDateUtc"},
                new object[,]
                {
                    {(ushort)150, (ushort)18, null},
                    {(ushort)164, (ushort)167, null},
                    {(ushort)330, (ushort)87, null},
                    {(ushort)330, (ushort)110, null},
                    {(ushort)283, (ushort)113, null},
                    {(ushort)334, (ushort)141, null},
                    {(ushort)269, (ushort)159, null},
                    {(ushort)335, (ushort)141, null},
                    {(ushort)264, (ushort)175, null},
                    {(ushort)336, (ushort)141, null},
                    {(ushort)289, (ushort)159, null},
                    {(ushort)263, (ushort)183, null},
                    {(ushort)262, (ushort)141, null},
                    {(ushort)338, (ushort)141, null},
                    {(ushort)261, (ushort)154, null},
                    {(ushort)339, (ushort)99, null},
                    {(ushort)260, (ushort)11, null},
                    {(ushort)340, (ushort)99, null},
                    {(ushort)258, (ushort)79, null},
                    {(ushort)258, (ushort)13, null},
                    {(ushort)163, (ushort)141, null},
                    {(ushort)337, (ushort)141, null},
                    {(ushort)347, (ushort)11, null},
                    {(ushort)329, (ushort)99, null},
                    {(ushort)292, (ushort)167, null},
                    {(ushort)342, (ushort)11, null},
                    {(ushort)332, (ushort)87, null},
                    {(ushort)351, (ushort)11, null},
                    {(ushort)479, (ushort)11, null},
                    {(ushort)350, (ushort)163, null},
                    {(ushort)315, (ushort)11, null},
                    {(ushort)349, (ushort)11, null},
                    {(ushort)345, (ushort)11, null},
                    {(ushort)508, (ushort)11, null},
                    {(ushort)290, (ushort)183, null},
                    {(ushort)305, (ushort)75, null},
                    {(ushort)300, (ushort)99, null},
                    {(ushort)167, (ushort)108, null},
                    {(ushort)299, (ushort)99, null},
                    {(ushort)297, (ushort)105, null},
                    {(ushort)297, (ushort)75, null},
                    {(ushort)166, (ushort)110, null},
                    {(ushort)295, (ushort)108, null},
                    {(ushort)294, (ushort)108, null},
                    {(ushort)293, (ushort)167, null},
                    {(ushort)316, (ushort)48, null},
                    {(ushort)257, (ushort)83, null},
                    {(ushort)256, (ushort)48, null},
                    {(ushort)254, (ushort)58, null},
                    {(ushort)331, (ushort)110, null},
                    {(ushort)30, (ushort)11, null},
                    {(ushort)326, (ushort)141, null},
                    {(ushort)20, (ushort)44, null},
                    {(ushort)333, (ushort)87, null},
                    {(ushort)341, (ushort)11, null},
                    {(ushort)399, (ushort)83, null},
                    {(ushort)14, (ushort)122, null},
                    {(ushort)343, (ushort)11, null},
                    {(ushort)56, (ushort)27, null},
                    {(ushort)13, (ushort)163, null},
                    {(ushort)12, (ushort)163, null},
                    {(ushort)11, (ushort)163, null},
                    {(ushort)369, (ushort)75, null},
                    {(ushort)369, (ushort)105, null},
                    {(ushort)416, (ushort)167, null},
                    {(ushort)422, (ushort)99, null},
                    {(ushort)422, (ushort)110, null},
                    {(ushort)6, (ushort)141, null},
                    {(ushort)1, (ushort)141, null},
                    {(ushort)13, (ushort)122, null},
                    {(ushort)61, (ushort)11, null},
                    {(ushort)331, (ushort)87, null},
                    {(ushort)328, (ushort)44, null},
                    {(ushort)248, (ushort)25, null},
                    {(ushort)246, (ushort)79, null},
                    {(ushort)161, (ushort)18, null},
                    {(ushort)240, (ushort)110, null},
                    {(ushort)430, (ushort)44, null},
                    {(ushort)84, (ushort)11, null},
                    {(ushort)435, (ushort)99, null},
                    {(ushort)224, (ushort)11, null},
                    {(ushort)158, (ushort)79, null},
                    {(ushort)158, (ushort)13, null},
                    {(ushort)156, (ushort)48, null},
                    {(ushort)223, (ushort)11, null},
                    {(ushort)216, (ushort)11, null},
                    {(ushort)16, (ushort)154, null},
                    {(ushort)480, (ushort)79, null},
                    {(ushort)197, (ushort)179, null},
                    {(ushort)134, (ushort)18, null},
                    {(ushort)133, (ushort)18, null},
                    {(ushort)131, (ushort)18, null},
                    {(ushort)384, (ushort)44, null},
                    {(ushort)117, (ushort)17, null},
                    {(ushort)344, (ushort)11, null},
                    {(ushort)346, (ushort)11, null},
                    {(ushort)305, (ushort)105, null},
                    {(ushort)225, (ushort)141, null},
                    {(ushort)198, (ushort)179, null},
                    {(ushort)199, (ushort)159, null},
                    {(ushort)200, (ushort)159, null},
                    {(ushort)386, (ushort)46, null},
                    {(ushort)201, (ushort)159, null},
                    {(ushort)202, (ushort)141, null},
                    {(ushort)203, (ushort)141, null},
                    {(ushort)204, (ushort)141, null},
                    {(ushort)182, (ushort)163, null},
                    {(ushort)205, (ushort)141, null},
                    {(ushort)215, (ushort)11, null},
                    {(ushort)217, (ushort)10, null},
                    {(ushort)218, (ushort)139, null},
                    {(ushort)219, (ushort)141, null},
                    {(ushort)220, (ushort)154, null},
                    {(ushort)221, (ushort)112, null},
                    {(ushort)222, (ushort)10, null},
                    {(ushort)136, (ushort)76, null},
                    {(ushort)206, (ushort)58, null},
                    {(ushort)228, (ushort)10, null},
                    {(ushort)181, (ushort)141, null},
                    {(ushort)72, (ushort)177, null},
                    {(ushort)370, (ushort)105, null},
                    {(ushort)132, (ushort)18, null},
                    {(ushort)119, (ushort)17, null},
                    {(ushort)370, (ushort)75, null},
                    {(ushort)146, (ushort)141, null},
                    {(ushort)147, (ushort)106, null},
                    {(ushort)118, (ushort)17, null},
                    {(ushort)116, (ushort)17, null},
                    {(ushort)178, (ushort)18, null},
                    {(ushort)390, (ushort)11, null},
                    {(ushort)153, (ushort)139, null},
                    {(ushort)388, (ushort)44, null},
                    {(ushort)101, (ushort)139, null},
                    {(ushort)100, (ushort)139, null},
                    {(ushort)154, (ushort)79, null},
                    {(ushort)171, (ushort)110, null},
                    {(ushort)171, (ushort)139, null},
                    {(ushort)99, (ushort)154, null},
                    {(ushort)113, (ushort)141, null},
                    {(ushort)230, (ushort)141, null},
                    {(ushort)387, (ushort)44, null},
                    {(ushort)402, (ushort)44, null},
                    {(ushort)63, (ushort)141, null},
                    {(ushort)291, (ushort)183, null},
                    {(ushort)62, (ushort)141, null},
                    {(ushort)296, (ushort)141, null},
                    {(ushort)231, (ushort)141, null},
                    {(ushort)59, (ushort)154, null},
                    {(ushort)429, (ushort)167, null},
                    {(ushort)53, (ushort)141, null},
                    {(ushort)51, (ushort)168, null},
                    {(ushort)60, (ushort)11, null},
                    {(ushort)49, (ushort)141, null},
                    {(ushort)39, (ushort)27, null},
                    {(ushort)437, (ushort)13, null},
                    {(ushort)31, (ushort)11, null},
                    {(ushort)15, (ushort)154, null},
                    {(ushort)284, (ushort)113, null},
                    {(ushort)298, (ushort)99, null},
                    {(ushort)69, (ushort)160, null},
                    {(ushort)245, (ushort)87, null},
                    {(ushort)278, (ushort)154, null},
                    {(ushort)277, (ushort)105, null},
                    {(ushort)429, (ushort)110, null},
                    {(ushort)237, (ushort)112, null},
                    {(ushort)251, (ushort)79, null},
                    {(ushort)268, (ushort)99, null},
                    {(ushort)267, (ushort)25, null},
                    {(ushort)281, (ushort)99, null},
                    {(ushort)251, (ushort)110, null},
                    {(ushort)252, (ushort)159, null},
                    {(ushort)253, (ushort)18, null}
                });

            migrationBuilder.InsertData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId", "CreatedDateUtc"},
                new object[,]
                {
                    {(ushort)381, (ushort)59, null},
                    {(ushort)61, (ushort)33, null},
                    {(ushort)377, (ushort)56, null},
                    {(ushort)7, (ushort)9, null},
                    {(ushort)14, (ushort)13, null},
                    {(ushort)328, (ushort)22, null},
                    {(ushort)385, (ushort)22, null},
                    {(ushort)6, (ushort)8, null},
                    {(ushort)9, (ushort)9, null},
                    {(ushort)20, (ushort)22, null},
                    {(ushort)14, (ushort)12, null},
                    {(ushort)30, (ushort)34, null},
                    {(ushort)12, (ushort)11, null},
                    {(ushort)12, (ushort)12, null},
                    {(ushort)331, (ushort)38, null},
                    {(ushort)12, (ushort)13, null},
                    {(ushort)19, (ushort)21, null},
                    {(ushort)343, (ushort)32, null},
                    {(ushort)18, (ushort)20, null},
                    {(ushort)376, (ushort)55, null},
                    {(ushort)341, (ushort)32, null},
                    {(ushort)346, (ushort)32, null},
                    {(ushort)391, (ushort)22, null},
                    {(ushort)387, (ushort)22, null},
                    {(ushort)373, (ushort)53, null},
                    {(ushort)369, (ushort)52, null},
                    {(ushort)305, (ushort)52, null},
                    {(ushort)307, (ushort)20, null},
                    {(ushort)314, (ushort)27, null},
                    {(ushort)372, (ushort)53, null},
                    {(ushort)429, (ushort)68, null},
                    {(ushort)315, (ushort)28, null},
                    {(ushort)374, (ushort)53, null},
                    {(ushort)356, (ushort)48, null},
                    {(ushort)327, (ushort)22, null},
                    {(ushort)355, (ushort)48, null},
                    {(ushort)332, (ushort)38, null},
                    {(ushort)432, (ushort)22, null},
                    {(ushort)354, (ushort)48, null},
                    {(ushort)342, (ushort)70, null},
                    {(ushort)344, (ushort)70, null},
                    {(ushort)353, (ushort)48, null},
                    {(ushort)434, (ushort)22, null},
                    {(ushort)375, (ushort)54, null},
                    {(ushort)403, (ushort)64, null},
                    {(ushort)394, (ushort)61, null},
                    {(ushort)398, (ushort)63, null},
                    {(ushort)313, (ushort)26, null},
                    {(ushort)312, (ushort)26, null},
                    {(ushort)207, (ushort)47, null},
                    {(ushort)311, (ushort)26, null},
                    {(ushort)91, (ushort)57, null},
                    {(ushort)216, (ushort)32, null},
                    {(ushort)90, (ushort)57, null},
                    {(ushort)223, (ushort)32, null},
                    {(ushort)390, (ushort)34, null},
                    {(ushort)89, (ushort)57, null},
                    {(ushort)88, (ushort)57, null},
                    {(ushort)224, (ushort)32, null},
                    {(ushort)87, (ushort)57, null},
                    {(ushort)84, (ushort)32, null},
                    {(ushort)352, (ushort)48, null},
                    {(ushort)83, (ushort)63, null},
                    {(ushort)27, (ushort)24, null},
                    {(ushort)392, (ushort)22, null},
                    {(ushort)386, (ushort)22, null},
                    {(ushort)5, (ushort)6, null},
                    {(ushort)431, (ushort)22, null},
                    {(ushort)1, (ushort)2, null},
                    {(ushort)349, (ushort)34, null},
                    {(ushort)345, (ushort)32, null},
                    {(ushort)172, (ushort)60, null},
                    {(ushort)169, (ushort)46, null},
                    {(ushort)167, (ushort)46, null},
                    {(ushort)316, (ushort)29, null},
                    {(ushort)317, (ushort)30, null},
                    {(ushort)166, (ushort)46, null},
                    {(ushort)318, (ushort)30, null},
                    {(ushort)320, (ushort)30, null},
                    {(ushort)324, (ushort)31, null},
                    {(ushort)165, (ushort)46, null},
                    {(ushort)325, (ushort)35, null},
                    {(ushort)164, (ushort)46, null},
                    {(ushort)329, (ushort)37, null},
                    {(ushort)330, (ushort)38, null},
                    {(ushort)334, (ushort)40, null},
                    {(ushort)335, (ushort)41, null},
                    {(ushort)336, (ushort)42, null},
                    {(ushort)337, (ushort)42, null},
                    {(ushort)338, (ushort)42, null},
                    {(ushort)339, (ushort)43, null},
                    {(ushort)2, (ushort)3, null},
                    {(ushort)163, (ushort)46, null},
                    {(ushort)347, (ushort)32, null},
                    {(ushort)360, (ushort)49, null},
                    {(ushort)162, (ushort)46, null},
                    {(ushort)361, (ushort)49, null},
                    {(ushort)161, (ushort)46, null},
                    {(ushort)350, (ushort)46, null},
                    {(ushort)362, (ushort)49, null},
                    {(ushort)351, (ushort)46, null},
                    {(ushort)309, (ushort)25, null},
                    {(ushort)397, (ushort)63, null},
                    {(ushort)396, (ushort)63, null},
                    {(ushort)393, (ushort)22, null},
                    {(ushort)388, (ushort)22, null},
                    {(ushort)136, (ushort)68, null},
                    {(ushort)370, (ushort)52, null},
                    {(ushort)363, (ushort)49, null},
                    {(ushort)130, (ushort)23, null},
                    {(ushort)125, (ushort)23, null},
                    {(ushort)123, (ushort)23, null},
                    {(ushort)121, (ushort)23, null},
                    {(ushort)75, (ushort)23, null},
                    {(ushort)23, (ushort)23, null},
                    {(ushort)389, (ushort)22, null},
                    {(ushort)348, (ushort)44, null},
                    {(ushort)128, (ushort)23, null},
                    {(ushort)127, (ushort)23, null},
                    {(ushort)76, (ushort)23, null},
                    {(ushort)15, (ushort)18, null},
                    {(ushort)60, (ushort)33, null},
                    {(ushort)25, (ushort)23, null},
                    {(ushort)437, (ushort)71, null},
                    {(ushort)168, (ushort)46, null},
                    {(ushort)3, (ushort)4, null},
                    {(ushort)4, (ushort)5, null},
                    {(ushort)10, (ushort)10, null},
                    {(ushort)17, (ushort)19, null},
                    {(ushort)308, (ushort)21, null},
                    {(ushort)368, (ushort)51, null},
                    {(ushort)367, (ushort)51, null},
                    {(ushort)378, (ushort)56, null},
                    {(ushort)340, (ushort)43, null},
                    {(ushort)319, (ushort)30, null},
                    {(ushort)275, (ushort)45, null},
                    {(ushort)310, (ushort)25, null},
                    {(ushort)401, (ushort)69, null},
                    {(ushort)321, (ushort)30, null},
                    {(ushort)322, (ushort)30, null},
                    {(ushort)323, (ushort)30, null},
                    {(ushort)326, (ushort)36, null},
                    {(ushort)405, (ushort)57, null},
                    {(ushort)333, (ushort)39, null},
                    {(ushort)399, (ushort)64, null},
                    {(ushort)357, (ushort)49, null},
                    {(ushort)358, (ushort)49, null},
                    {(ushort)359, (ushort)49, null},
                    {(ushort)410, (ushort)57, null},
                    {(ushort)380, (ushort)58, null},
                    {(ushort)365, (ushort)50, null},
                    {(ushort)366, (ushort)50, null},
                    {(ushort)395, (ushort)62, null},
                    {(ushort)400, (ushort)69, null},
                    {(ushort)411, (ushort)66, null},
                    {(ushort)412, (ushort)66, null},
                    {(ushort)413, (ushort)66, null},
                    {(ushort)414, (ushort)66, null},
                    {(ushort)415, (ushort)66, null},
                    {(ushort)416, (ushort)66, null},
                    {(ushort)419, (ushort)67, null},
                    {(ushort)420, (ushort)67, null},
                    {(ushort)379, (ushort)57, null},
                    {(ushort)364, (ushort)50, null},
                    {(ushort)274, (ushort)45, null},
                    {(ushort)384, (ushort)22, null},
                    {(ushort)26, (ushort)23, null},
                    {(ushort)24, (ushort)23, null},
                    {(ushort)156, (ushort)46, null},
                    {(ushort)155, (ushort)46, null},
                    {(ushort)273, (ushort)45, null},
                    {(ushort)157, (ushort)46, null},
                    {(ushort)16, (ushort)18, null},
                    {(ushort)37, (ushort)23, null},
                    {(ushort)77, (ushort)23, null},
                    {(ushort)122, (ushort)23, null},
                    {(ushort)124, (ushort)23, null},
                    {(ushort)159, (ushort)46, null},
                    {(ushort)158, (ushort)46, null},
                    {(ushort)126, (ushort)23, null},
                    {(ushort)430, (ushort)22, null},
                    {(ushort)160, (ushort)46, null},
                    {(ushort)272, (ushort)45, null},
                    {(ushort)129, (ushort)23, null},
                    {(ushort)8, (ushort)9, null},
                    {(ushort)433, (ushort)22, null}
                });

            migrationBuilder.InsertData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId", "CreatedDateUtc"},
                new object[,]
                {
                    {(ushort)159, (byte)4, null},
                    {(ushort)343, (byte)8, null},
                    {(ushort)391, (byte)15, null},
                    {(ushort)370, (byte)17, null},
                    {(ushort)388, (byte)17, null},
                    {(ushort)392, (byte)16, null},
                    {(ushort)390, (byte)15, null},
                    {(ushort)84, (byte)2, null},
                    {(ushort)402, (byte)10, null},
                    {(ushort)155, (byte)10, null},
                    {(ushort)363, (byte)1, null},
                    {(ushort)508, (byte)10, null},
                    {(ushort)345, (byte)2, null},
                    {(ushort)389, (byte)13, null},
                    {(ushort)506, (byte)10, null},
                    {(ushort)169, (byte)9, null},
                    {(ushort)349, (byte)9, null},
                    {(ushort)434, (byte)15, null},
                    {(ushort)405, (byte)9, null},
                    {(ushort)432, (byte)15, null},
                    {(ushort)313, (byte)9, null},
                    {(ushort)403, (byte)15, null},
                    {(ushort)433, (byte)15, null},
                    {(ushort)311, (byte)9, null},
                    {(ushort)371, (byte)13, null},
                    {(ushort)371, (byte)15, null},
                    {(ushort)382, (byte)11, null},
                    {(ushort)508, (byte)7, null},
                    {(ushort)341, (byte)4, null},
                    {(ushort)379, (byte)4, null},
                    {(ushort)436, (byte)9, null},
                    {(ushort)83, (byte)5, null},
                    {(ushort)483, (byte)11, null},
                    {(ushort)381, (byte)15, null},
                    {(ushort)318, (byte)1, null},
                    {(ushort)340, (byte)12, null},
                    {(ushort)360, (byte)1, null},
                    {(ushort)361, (byte)1, null},
                    {(ushort)362, (byte)1, null},
                    {(ushort)435, (byte)12, null},
                    {(ushort)472, (byte)4, null},
                    {(ushort)474, (byte)4, null},
                    {(ushort)491, (byte)11, null},
                    {(ushort)492, (byte)11, null},
                    {(ushort)308, (byte)1, null},
                    {(ushort)493, (byte)11, null},
                    {(ushort)501, (byte)4, null},
                    {(ushort)502, (byte)4, null},
                    {(ushort)384, (byte)10, null},
                    {(ushort)333, (byte)13, null},
                    {(ushort)357, (byte)1, null},
                    {(ushort)358, (byte)1, null},
                    {(ushort)359, (byte)1, null},
                    {(ushort)365, (byte)4, null},
                    {(ushort)422, (byte)13, null},
                    {(ushort)5, (byte)15, null},
                    {(ushort)500, (byte)4, null},
                    {(ushort)18, (byte)9, null},
                    {(ushort)60, (byte)7, null},
                    {(ushort)303, (byte)14, null},
                    {(ushort)487, (byte)11, null},
                    {(ushort)33, (byte)16, null},
                    {(ushort)38, (byte)15, null},
                    {(ushort)70, (byte)8, null},
                    {(ushort)71, (byte)8, null},
                    {(ushort)102, (byte)9, null},
                    {(ushort)141, (byte)10, null},
                    {(ushort)143, (byte)10, null},
                    {(ushort)144, (byte)10, null},
                    {(ushort)145, (byte)10, null},
                    {(ushort)507, (byte)17, null},
                    {(ushort)151, (byte)10, null},
                    {(ushort)175, (byte)8, null},
                    {(ushort)225, (byte)4, null},
                    {(ushort)226, (byte)4, null},
                    {(ushort)232, (byte)15, null},
                    {(ushort)238, (byte)10, null},
                    {(ushort)270, (byte)14, null},
                    {(ushort)279, (byte)8, null},
                    {(ushort)280, (byte)15, null},
                    {(ushort)285, (byte)14, null},
                    {(ushort)286, (byte)14, null},
                    {(ushort)153, (byte)4, null},
                    {(ushort)19, (byte)1, null},
                    {(ushort)503, (byte)4, null},
                    {(ushort)61, (byte)7, null},
                    {(ushort)216, (byte)4, null},
                    {(ushort)223, (byte)2, null},
                    {(ushort)223, (byte)4, null},
                    {(ushort)224, (byte)4, null},
                    {(ushort)224, (byte)8, null},
                    {(ushort)227, (byte)10, null},
                    {(ushort)229, (byte)4, null},
                    {(ushort)235, (byte)9, null},
                    {(ushort)236, (byte)9, null},
                    {(ushort)214, (byte)5, null},
                    {(ushort)250, (byte)8, null},
                    {(ushort)306, (byte)15, null},
                    {(ushort)314, (byte)1, null},
                    {(ushort)315, (byte)2, null},
                    {(ushort)315, (byte)3, null},
                    {(ushort)315, (byte)15, null},
                    {(ushort)327, (byte)9, null},
                    {(ushort)332, (byte)16, null},
                    {(ushort)356, (byte)9, null},
                    {(ushort)373, (byte)4, null},
                    {(ushort)30, (byte)9, null},
                    {(ushort)207, (byte)5, null},
                    {(ushort)398, (byte)9, null},
                    {(ushort)98, (byte)9, null},
                    {(ushort)134, (byte)9, null},
                    {(ushort)150, (byte)15, null},
                    {(ushort)94, (byte)10, null},
                    {(ushort)184, (byte)4, null}
                });

            migrationBuilder.InsertData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId", "CreatedDateUtc"},
                new object[,]
                {
                    {(ushort)166, (ushort)301, null},
                    {(ushort)163, (ushort)262, null},
                    {(ushort)167, (ushort)295, null},
                    {(ushort)8, (ushort)9, null},
                    {(ushort)7, (ushort)9, null},
                    {(ushort)313, (ushort)311, null},
                    {(ushort)158, (ushort)258, null},
                    {(ushort)164, (ushort)293, null},
                    {(ushort)312, (ushort)311, null},
                    {(ushort)16, (ushort)278, null},
                    {(ushort)16, (ushort)99, null},
                    {(ushort)16, (ushort)59, null},
                    {(ushort)350, (ushort)12, null}
                });

            migrationBuilder.InsertData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId", "CreatedDateUtc"},
                new object[,]
                {
                    {(ushort)13, (ushort)14, null},
                    {(ushort)375, (ushort)2, null},
                    {(ushort)21, (ushort)23, null},
                    {(ushort)371, (ushort)110, null},
                    {(ushort)331, (ushort)199, null},
                    {(ushort)331, (ushort)330, null},
                    {(ushort)371, (ushort)232, null},
                    {(ushort)13, (ushort)12, null},
                    {(ushort)120, (ushort)127, null},
                    {(ushort)13, (ushort)301, null},
                    {(ushort)331, (ushort)333, null},
                    {(ushort)120, (ushort)25, null},
                    {(ushort)120, (ushort)76, null},
                    {(ushort)120, (ushort)128, null},
                    {(ushort)331, (ushort)332, null},
                    {(ushort)21, (ushort)75, null},
                    {(ushort)21, (ushort)125, null},
                    {(ushort)21, (ushort)121, null},
                    {(ushort)375, (ushort)307, null},
                    {(ushort)375, (ushort)279, null},
                    {(ushort)375, (ushort)247, null},
                    {(ushort)375, (ushort)232, null},
                    {(ushort)375, (ushort)214, null},
                    {(ushort)375, (ushort)184, null},
                    {(ushort)375, (ushort)183, null},
                    {(ushort)375, (ushort)174, null},
                    {(ushort)375, (ushort)18, null},
                    {(ushort)375, (ushort)148, null},
                    {(ushort)375, (ushort)97, null},
                    {(ushort)375, (ushort)71, null},
                    {(ushort)21, (ushort)130, null},
                    {(ushort)375, (ushort)70, null},
                    {(ushort)168, (ushort)242, null},
                    {(ushort)375, (ushort)38, null},
                    {(ushort)21, (ushort)123, null},
                    {(ushort)375, (ushort)19, null},
                    {(ushort)375, (ushort)99, null},
                    {(ushort)168, (ushort)301, null},
                    {(ushort)309, (ushort)81, null},
                    {(ushort)309, (ushort)17, null},
                    {(ushort)309, (ushort)329, null},
                    {(ushort)309, (ushort)255, null},
                    {(ushort)309, (ushort)340, null},
                    {(ushort)168, (ushort)162, null},
                    {(ushort)375, (ushort)27, null},
                    {(ushort)168, (ushort)159, null},
                    {(ushort)309, (ushort)170, null},
                    {(ushort)168, (ushort)157, null},
                    {(ushort)309, (ushort)326, null},
                    {(ushort)274, (ushort)275, null},
                    {(ushort)274, (ushort)273, null},
                    {(ushort)22, (ushort)24, null},
                    {(ushort)22, (ushort)26, null},
                    {(ushort)22, (ushort)37, null},
                    {(ushort)22, (ushort)77, null},
                    {(ushort)22, (ushort)122, null},
                    {(ushort)22, (ushort)124, null},
                    {(ushort)309, (ushort)325, null},
                    {(ushort)11, (ushort)12, null},
                    {(ushort)309, (ushort)324, null},
                    {(ushort)309, (ushort)317, null},
                    {(ushort)309, (ushort)32, null},
                    {(ushort)309, (ushort)35, null},
                    {(ushort)309, (ushort)47, null},
                    {(ushort)309, (ushort)54, null},
                    {(ushort)309, (ushort)80, null},
                    {(ushort)22, (ushort)129, null},
                    {(ushort)309, (ushort)99, null},
                    {(ushort)309, (ushort)138, null},
                    {(ushort)309, (ushort)177, null},
                    {(ushort)309, (ushort)179, null},
                    {(ushort)309, (ushort)206, null},
                    {(ushort)309, (ushort)226, null},
                    {(ushort)309, (ushort)276, null},
                    {(ushort)309, (ushort)282, null},
                    {(ushort)309, (ushort)316, null},
                    {(ushort)168, (ushort)166, null},
                    {(ushort)11, (ushort)301, null},
                    {(ushort)271, (ushort)338, null},
                    {(ushort)22, (ushort)126, null}
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)28);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)29);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)34);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)36);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)40);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)41);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)42);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)43);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)44);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)45);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)46);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)48);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)50);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)52);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)55);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)57);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)58);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)64);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)65);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)66);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)67);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)68);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)73);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)74);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)78);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)79);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)82);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)85);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)86);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)93);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)95);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)96);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)103);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)104);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)105);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)106);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)107);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)108);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)109);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)111);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)112);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)114);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)115);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)135);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)137);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)139);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)140);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)142);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)149);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)152);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)173);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)176);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)180);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)185);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)186);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)187);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)188);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)189);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)190);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)191);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)192);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)193);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)194);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)195);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)196);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)208);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)209);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)210);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)211);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)212);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)213);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)233);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)234);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)239);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)241);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)243);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)244);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)249);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)259);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)265);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)266);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)287);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)288);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)302);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)304);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)383);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)417);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)418);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)421);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)423);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)424);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)425);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)426);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)427);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)428);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)438);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)439);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)440);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)441);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)442);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)443);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)444);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)445);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)446);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)447);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)448);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)449);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)450);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)451);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)452);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)453);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)454);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)455);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)460);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)461);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)462);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)463);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)464);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)465);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)466);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)467);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)468);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)469);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)470);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)471);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)473);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)475);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)476);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)477);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)478);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)481);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)482);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)484);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)485);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)486);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)488);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)489);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)490);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)494);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)495);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)496);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)497);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)498);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)499);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)504);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)505);

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)1, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)6, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)11, (ushort)163});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)12, (ushort)163});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)13, (ushort)122});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)13, (ushort)163});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)14, (ushort)122});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)15, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)16, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)20, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)30, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)31, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)39, (ushort)27});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)49, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)51, (ushort)168});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)53, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)56, (ushort)27});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)59, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)60, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)61, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)62, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)63, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)69, (ushort)160});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)72, (ushort)177});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)84, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)99, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)100, (ushort)139});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)101, (ushort)139});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)113, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)116, (ushort)17});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)117, (ushort)17});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)118, (ushort)17});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)119, (ushort)17});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)131, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)132, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)133, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)134, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)136, (ushort)76});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)146, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)147, (ushort)106});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)150, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)153, (ushort)139});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)154, (ushort)79});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)156, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)158, (ushort)13});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)158, (ushort)79});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)161, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)163, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)164, (ushort)167});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)166, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)167, (ushort)108});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)171, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)171, (ushort)139});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)178, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)181, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)182, (ushort)163});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)197, (ushort)179});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)198, (ushort)179});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)199, (ushort)159});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)200, (ushort)159});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)201, (ushort)159});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)202, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)203, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)204, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)205, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)206, (ushort)58});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)215, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)216, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)217, (ushort)10});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)218, (ushort)139});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)219, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)220, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)221, (ushort)112});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)222, (ushort)10});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)223, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)224, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)225, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)228, (ushort)10});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)230, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)231, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)237, (ushort)112});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)240, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)245, (ushort)87});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)246, (ushort)79});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)248, (ushort)25});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)251, (ushort)79});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)251, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)252, (ushort)159});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)253, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)254, (ushort)58});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)256, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)257, (ushort)83});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)258, (ushort)13});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)258, (ushort)79});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)260, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)261, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)262, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)263, (ushort)183});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)264, (ushort)175});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)267, (ushort)25});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)268, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)269, (ushort)159});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)277, (ushort)105});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)278, (ushort)154});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)281, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)283, (ushort)113});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)284, (ushort)113});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)289, (ushort)159});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)290, (ushort)183});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)291, (ushort)183});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)292, (ushort)167});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)293, (ushort)167});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)294, (ushort)108});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)295, (ushort)108});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)296, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)297, (ushort)75});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)297, (ushort)105});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)298, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)299, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)300, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)305, (ushort)75});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)305, (ushort)105});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)315, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)316, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)326, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)328, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)329, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)330, (ushort)87});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)330, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)331, (ushort)87});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)331, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)332, (ushort)87});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)333, (ushort)87});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)334, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)335, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)336, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)337, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)338, (ushort)141});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)339, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)340, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)341, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)342, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)343, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)344, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)345, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)346, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)347, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)349, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)350, (ushort)163});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)351, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)369, (ushort)75});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)369, (ushort)105});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)370, (ushort)75});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)370, (ushort)105});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)384, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)386, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)387, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)388, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)390, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)399, (ushort)83});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)402, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)416, (ushort)167});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)422, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)422, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)429, (ushort)110});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)429, (ushort)167});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)430, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)435, (ushort)99});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)437, (ushort)13});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)479, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)480, (ushort)79});

            migrationBuilder.DeleteData(
                "filterlists_languages",
                new[] {"FilterListId", "LanguageId"},
                new object[] {(ushort)508, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)1, (ushort)2});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)2, (ushort)3});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)3, (ushort)4});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)4, (ushort)5});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)5, (ushort)6});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)6, (ushort)8});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)7, (ushort)9});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)8, (ushort)9});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)9, (ushort)9});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)10, (ushort)10});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)12, (ushort)11});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)12, (ushort)12});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)12, (ushort)13});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)14, (ushort)12});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)14, (ushort)13});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)15, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)16, (ushort)18});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)17, (ushort)19});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)18, (ushort)20});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)19, (ushort)21});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)20, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)23, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)24, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)25, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)26, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)27, (ushort)24});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)30, (ushort)34});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)37, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)60, (ushort)33});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)61, (ushort)33});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)75, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)76, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)77, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)83, (ushort)63});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)84, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)87, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)88, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)89, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)90, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)91, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)121, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)122, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)123, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)124, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)125, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)126, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)127, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)128, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)129, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)130, (ushort)23});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)136, (ushort)68});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)155, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)156, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)157, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)158, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)159, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)160, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)161, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)162, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)163, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)164, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)165, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)166, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)167, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)168, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)169, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)172, (ushort)60});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)207, (ushort)47});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)216, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)223, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)224, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)272, (ushort)45});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)273, (ushort)45});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)274, (ushort)45});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)275, (ushort)45});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)305, (ushort)52});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)307, (ushort)20});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)308, (ushort)21});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)309, (ushort)25});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)310, (ushort)25});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)311, (ushort)26});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)312, (ushort)26});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)313, (ushort)26});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)314, (ushort)27});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)315, (ushort)28});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)316, (ushort)29});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)317, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)318, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)319, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)320, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)321, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)322, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)323, (ushort)30});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)324, (ushort)31});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)325, (ushort)35});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)326, (ushort)36});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)327, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)328, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)329, (ushort)37});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)330, (ushort)38});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)331, (ushort)38});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)332, (ushort)38});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)333, (ushort)39});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)334, (ushort)40});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)335, (ushort)41});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)336, (ushort)42});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)337, (ushort)42});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)338, (ushort)42});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)339, (ushort)43});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)340, (ushort)43});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)341, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)342, (ushort)70});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)343, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)344, (ushort)70});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)345, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)346, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)347, (ushort)32});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)348, (ushort)44});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)349, (ushort)34});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)350, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)351, (ushort)46});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)352, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)353, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)354, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)355, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)356, (ushort)48});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)357, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)358, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)359, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)360, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)361, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)362, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)363, (ushort)49});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)364, (ushort)50});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)365, (ushort)50});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)366, (ushort)50});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)367, (ushort)51});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)368, (ushort)51});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)369, (ushort)52});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)370, (ushort)52});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)372, (ushort)53});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)373, (ushort)53});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)374, (ushort)53});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)375, (ushort)54});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)376, (ushort)55});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)377, (ushort)56});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)378, (ushort)56});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)379, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)380, (ushort)58});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)381, (ushort)59});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)384, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)385, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)386, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)387, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)388, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)389, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)390, (ushort)34});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)391, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)392, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)393, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)394, (ushort)61});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)395, (ushort)62});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)396, (ushort)63});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)397, (ushort)63});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)398, (ushort)63});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)399, (ushort)64});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)400, (ushort)69});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)401, (ushort)69});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)403, (ushort)64});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)405, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)410, (ushort)57});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)411, (ushort)66});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)412, (ushort)66});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)413, (ushort)66});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)414, (ushort)66});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)415, (ushort)66});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)416, (ushort)66});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)419, (ushort)67});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)420, (ushort)67});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)429, (ushort)68});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)430, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)431, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)432, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)433, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)434, (ushort)22});

            migrationBuilder.DeleteData(
                "filterlists_maintainers",
                new[] {"FilterListId", "MaintainerId"},
                new object[] {(ushort)437, (ushort)71});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)5, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)18, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)19, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)30, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)33, (byte)16});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)38, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)60, (byte)7});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)61, (byte)7});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)70, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)71, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)83, (byte)5});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)84, (byte)2});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)94, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)98, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)102, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)134, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)141, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)143, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)144, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)145, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)150, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)151, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)153, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)155, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)159, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)169, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)175, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)184, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)207, (byte)5});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)214, (byte)5});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)216, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)223, (byte)2});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)223, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)224, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)224, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)225, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)226, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)227, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)229, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)232, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)235, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)236, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)238, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)250, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)270, (byte)14});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)279, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)280, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)285, (byte)14});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)286, (byte)14});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)303, (byte)14});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)306, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)308, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)311, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)313, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)314, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)315, (byte)2});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)315, (byte)3});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)315, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)318, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)327, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)332, (byte)16});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)333, (byte)13});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)340, (byte)12});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)341, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)343, (byte)8});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)345, (byte)2});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)349, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)356, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)357, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)358, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)359, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)360, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)361, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)362, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)363, (byte)1});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)365, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)370, (byte)17});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)371, (byte)13});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)371, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)373, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)379, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)381, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)382, (byte)11});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)384, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)388, (byte)17});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)389, (byte)13});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)390, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)391, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)392, (byte)16});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)398, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)402, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)403, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)405, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)422, (byte)13});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)432, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)433, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)434, (byte)15});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)435, (byte)12});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)436, (byte)9});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)472, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)474, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)483, (byte)11});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)487, (byte)11});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)491, (byte)11});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)492, (byte)11});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)493, (byte)11});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)500, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)501, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)502, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)503, (byte)4});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)506, (byte)10});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)507, (byte)17});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)508, (byte)7});

            migrationBuilder.DeleteData(
                "filterlists_tags",
                new[] {"FilterListId", "TagId"},
                new object[] {(ushort)508, (byte)10});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)7, (ushort)9});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)8, (ushort)9});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)16, (ushort)59});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)16, (ushort)99});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)16, (ushort)278});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)158, (ushort)258});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)163, (ushort)262});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)164, (ushort)293});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)166, (ushort)301});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)167, (ushort)295});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)312, (ushort)311});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)313, (ushort)311});

            migrationBuilder.DeleteData(
                "forks",
                new[] {"ForkFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)350, (ushort)12});

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)1);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)2);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)3);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)4);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)5);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)6);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)7);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)8);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)9);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)12);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)14);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)15);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)16);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)19);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)20);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)21);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)22);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)23);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)24);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)26);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)28);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)29);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)30);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)31);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)32);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)33);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)34);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)35);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)36);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)37);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)38);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)39);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)40);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)41);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)42);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)43);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)45);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)47);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)49);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)50);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)51);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)52);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)53);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)54);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)55);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)56);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)57);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)59);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)60);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)61);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)62);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)63);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)64);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)65);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)66);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)67);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)68);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)69);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)70);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)71);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)72);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)73);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)74);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)77);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)78);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)80);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)81);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)82);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)84);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)85);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)86);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)88);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)89);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)90);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)91);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)92);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)93);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)94);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)95);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)96);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)97);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)98);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)100);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)101);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)102);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)103);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)104);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)107);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)109);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)111);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)114);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)115);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)116);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)117);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)118);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)119);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)120);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)121);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)123);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)124);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)125);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)126);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)127);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)128);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)129);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)130);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)131);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)132);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)133);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)134);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)135);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)136);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)137);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)138);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)140);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)142);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)143);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)144);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)145);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)146);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)147);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)148);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)149);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)150);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)151);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)152);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)153);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)155);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)156);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)157);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)158);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)161);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)162);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)164);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)165);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)166);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)169);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)170);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)171);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)172);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)173);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)174);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)176);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)178);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)180);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)181);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)182);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)184);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)7);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)14);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)15);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)16);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)17);

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)11, (ushort)12});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)11, (ushort)301});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)13, (ushort)12});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)13, (ushort)14});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)13, (ushort)301});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)21, (ushort)23});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)21, (ushort)75});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)21, (ushort)121});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)21, (ushort)123});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)21, (ushort)125});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)21, (ushort)130});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)24});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)26});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)37});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)77});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)122});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)124});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)126});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)22, (ushort)129});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)120, (ushort)25});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)120, (ushort)76});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)120, (ushort)127});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)120, (ushort)128});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)168, (ushort)157});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)168, (ushort)159});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)168, (ushort)162});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)168, (ushort)166});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)168, (ushort)242});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)168, (ushort)301});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)271, (ushort)338});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)274, (ushort)273});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)274, (ushort)275});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)17});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)32});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)35});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)47});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)54});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)80});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)81});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)99});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)138});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)170});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)177});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)179});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)206});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)226});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)255});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)276});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)282});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)316});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)317});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)324});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)325});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)326});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)329});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)309, (ushort)340});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)331, (ushort)199});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)331, (ushort)330});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)331, (ushort)332});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)331, (ushort)333});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)371, (ushort)110});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)371, (ushort)232});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)2});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)18});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)19});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)27});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)38});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)70});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)71});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)97});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)99});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)148});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)174});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)183});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)184});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)214});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)232});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)247});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)279});

            migrationBuilder.DeleteData(
                "merges",
                new[] {"MergeFilterListId", "UpstreamFilterListId"},
                new object[] {(ushort)375, (ushort)307});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)1, (byte)7});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)1, (byte)11});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)1, (byte)12});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)2, (byte)8});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)2, (byte)9});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)3, (byte)2});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)3, (byte)4});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)3, (byte)6});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)4, (byte)1});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)4, (byte)5});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)6, (byte)3});

            migrationBuilder.DeleteData(
                "software_syntaxes",
                new[] {"SyntaxId", "SoftwareId"},
                new object[] {(byte)11, (byte)10});

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)6);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)1);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)2);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)3);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)4);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)5);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)6);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)7);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)8);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)9);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)10);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)11);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)12);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)13);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)14);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)15);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)16);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)17);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)18);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)19);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)20);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)21);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)22);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)23);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)24);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)25);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)26);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)27);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)30);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)31);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)32);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)33);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)35);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)37);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)38);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)39);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)47);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)49);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)51);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)53);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)54);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)56);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)59);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)60);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)61);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)62);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)63);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)69);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)70);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)71);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)72);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)75);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)76);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)77);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)80);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)81);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)83);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)84);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)87);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)88);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)89);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)90);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)91);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)94);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)97);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)98);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)99);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)100);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)101);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)102);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)110);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)113);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)116);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)117);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)118);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)119);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)120);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)121);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)122);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)123);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)124);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)125);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)126);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)127);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)128);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)129);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)130);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)131);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)132);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)133);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)134);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)136);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)138);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)141);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)143);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)144);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)145);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)146);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)147);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)148);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)150);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)151);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)153);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)154);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)155);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)156);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)157);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)158);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)159);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)160);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)161);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)162);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)163);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)164);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)165);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)166);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)167);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)168);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)169);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)170);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)171);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)172);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)174);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)175);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)177);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)178);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)179);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)181);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)182);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)183);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)184);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)197);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)198);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)199);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)200);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)201);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)202);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)203);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)204);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)205);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)206);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)207);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)214);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)215);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)216);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)217);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)218);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)219);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)220);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)221);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)222);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)223);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)224);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)225);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)226);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)227);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)228);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)229);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)230);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)231);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)232);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)235);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)236);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)237);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)238);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)240);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)242);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)245);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)246);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)247);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)248);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)250);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)251);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)252);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)253);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)254);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)255);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)256);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)257);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)258);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)260);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)261);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)262);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)263);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)264);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)267);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)268);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)269);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)270);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)271);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)272);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)273);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)274);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)275);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)276);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)277);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)278);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)279);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)280);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)281);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)282);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)283);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)284);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)285);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)286);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)289);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)290);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)291);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)292);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)293);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)294);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)295);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)296);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)297);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)298);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)299);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)300);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)301);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)303);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)305);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)306);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)307);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)308);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)309);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)310);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)311);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)312);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)313);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)314);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)315);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)316);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)317);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)318);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)319);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)320);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)321);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)322);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)323);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)324);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)325);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)326);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)327);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)328);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)329);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)330);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)331);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)332);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)333);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)334);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)335);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)336);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)337);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)338);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)339);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)340);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)341);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)342);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)343);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)344);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)345);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)346);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)347);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)348);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)349);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)350);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)351);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)352);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)353);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)354);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)355);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)356);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)357);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)358);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)359);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)360);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)361);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)362);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)363);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)364);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)365);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)366);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)367);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)368);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)369);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)370);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)371);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)372);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)373);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)374);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)375);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)376);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)377);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)378);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)379);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)380);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)381);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)382);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)384);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)385);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)386);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)387);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)388);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)389);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)390);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)391);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)392);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)393);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)394);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)395);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)396);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)397);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)398);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)399);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)400);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)401);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)402);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)403);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)405);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)410);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)411);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)412);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)413);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)414);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)415);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)416);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)419);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)420);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)422);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)429);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)430);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)431);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)432);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)433);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)434);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)435);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)436);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)437);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)472);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)474);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)479);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)480);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)483);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)487);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)491);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)492);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)493);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)500);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)501);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)502);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)503);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)506);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)507);

            migrationBuilder.DeleteData(
                "filterlists",
                "Id",
                (ushort)508);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)10);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)11);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)13);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)17);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)18);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)25);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)27);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)44);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)46);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)48);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)58);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)75);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)76);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)79);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)83);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)87);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)99);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)105);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)106);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)108);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)110);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)112);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)113);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)122);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)139);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)141);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)154);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)159);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)160);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)163);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)167);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)168);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)175);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)177);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)179);

            migrationBuilder.DeleteData(
                "languages",
                "Id",
                (ushort)183);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)19);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)20);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)21);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)23);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)2);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)3);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)4);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)5);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)6);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)8);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)9);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)10);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)11);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)12);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)13);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)18);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)19);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)20);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)21);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)22);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)23);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)24);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)25);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)26);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)27);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)28);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)29);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)30);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)31);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)32);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)33);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)34);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)35);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)36);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)37);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)38);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)39);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)40);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)41);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)42);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)43);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)44);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)45);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)46);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)47);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)48);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)49);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)50);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)51);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)52);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)53);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)54);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)55);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)56);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)57);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)58);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)59);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)60);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)61);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)62);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)63);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)64);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)66);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)67);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)68);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)69);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)70);

            migrationBuilder.DeleteData(
                "maintainers",
                "Id",
                (ushort)71);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)1);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)2);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)3);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)4);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)5);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)6);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)7);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)8);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)9);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)10);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)11);

            migrationBuilder.DeleteData(
                "software",
                "Id",
                (byte)12);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)1);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)2);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)3);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)4);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)5);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)7);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)8);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)9);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)10);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)11);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)12);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)13);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)14);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)15);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)16);

            migrationBuilder.DeleteData(
                "tags",
                "Id",
                (byte)17);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)1);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)2);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)3);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)4);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)5);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)6);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)7);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)8);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)9);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)10);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)11);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)12);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)13);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)14);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)15);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)16);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)17);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)18);

            migrationBuilder.DeleteData(
                "licenses",
                "Id",
                (byte)22);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)1);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)2);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)3);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)4);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)6);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)7);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)8);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)9);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)10);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)11);

            migrationBuilder.DeleteData(
                "syntaxes",
                "Id",
                (byte)12);

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "tags",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "tags",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "syntaxes",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "syntaxes",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "software_syntaxes",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "software",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "software",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "rules",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "merges",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "maintainers",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "maintainers",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "licenses",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "licenses",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "languages",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "languages",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "forks",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists_tags",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists_maintainers",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists_languages",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "filterlists",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDateUtc",
                "filterlists",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");
        }
    }
}