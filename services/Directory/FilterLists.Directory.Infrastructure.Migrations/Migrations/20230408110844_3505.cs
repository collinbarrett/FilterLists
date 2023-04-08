using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3505 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2815L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2816L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2817L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2819L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2820L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2821L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2823L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2824L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2825L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2827L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2828L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2829L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2831L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2832L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2833L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2814L },
                column: "url",
                value: "https://0xacab.org/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/wildcard.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2818L },
                column: "url",
                value: "https://0xacab.org/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/tld.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2822L },
                column: "url",
                value: "https://0xacab.org/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/domains.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2826L },
                column: "url",
                value: "https://0xacab.org/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/hosts.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2830L },
                column: "url",
                value: "https://0xacab.org/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/snuff.list");

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[,]
                {
                    { 2566L, 2926L, (short)2, (short)1, "http://wmj5kiic7b6kjplpbvwadnht2nh2qnkbnqtcv3dyvpqtz7ssbssftxid.onion/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/wildcard.list" },
                    { 2566L, 2927L, (short)2, (short)2, "http://wmj5kiic7b6kjplpbvwadnht2nh2qnkbnqtcv3dyvpqtz7ssbssftxid.onion/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/tld.list" },
                    { 2566L, 2928L, (short)2, (short)3, "http://wmj5kiic7b6kjplpbvwadnht2nh2qnkbnqtcv3dyvpqtz7ssbssftxid.onion/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/domains.list" },
                    { 2566L, 2929L, (short)2, (short)4, "http://wmj5kiic7b6kjplpbvwadnht2nh2qnkbnqtcv3dyvpqtz7ssbssftxid.onion/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/hosts.list" },
                    { 2566L, 2930L, (short)2, (short)5, "http://wmj5kiic7b6kjplpbvwadnht2nh2qnkbnqtcv3dyvpqtz7ssbssftxid.onion/my-privacy-dns/matrix/-/raw/master/source/porn_filters/explicit_content/snuff.list" }
                });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1933L,
                column: "home_url",
                value: "https://0xacab.org/my-privacy-dns/matrix");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1934L,
                column: "home_url",
                value: "https://0xacab.org/my-privacy-dns/matrix");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2566L,
                columns: new[] { "email_address", "forum_url", "home_url", "issues_url", "onion_url", "policy_url", "submission_url" },
                values: new object[] { "0xacab+my-privacy-dns-support-4711-issue-@riseup.net", "https://0xacab.org/my-privacy-dns/support/-/issues", "https://0xacab.org/my-privacy-dns/matrix", "https://0xacab.org/my-privacy-dns/matrix/-/issues", "http://wmj5kiic7b6kjplpbvwadnht2nh2qnkbnqtcv3dyvpqtz7ssbssftxid.onion/my-privacy-dns/matrix", "https://0xacab.org/my-privacy-dns/matrix/-/blob/master/source/porn_filters/README.md", "https://0xacab.org/my-privacy-dns/matrix/-/issues" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2926L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2927L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2928L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2929L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2930L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2814L },
                column: "url",
                value: "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/wildcard.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2818L },
                column: "url",
                value: "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/tld.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2822L },
                column: "url",
                value: "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/domains.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2826L },
                column: "url",
                value: "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/hosts.list");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2830L },
                column: "url",
                value: "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/snuff.list");

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[,]
                {
                    { 2566L, 2815L, (short)2, (short)1, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2816L, (short)3, (short)1, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2817L, (short)4, (short)1, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2819L, (short)2, (short)2, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2820L, (short)3, (short)2, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2821L, (short)4, (short)2, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2823L, (short)2, (short)3, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2824L, (short)3, (short)3, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2825L, (short)4, (short)3, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2827L, (short)2, (short)4, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2828L, (short)3, (short)4, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2829L, (short)4, (short)4, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2831L, (short)2, (short)5, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/snuff.list" },
                    { 2566L, 2832L, (short)3, (short)5, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/snuff.list" },
                    { 2566L, 2833L, (short)4, (short)5, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/snuff.list" }
                });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1933L,
                column: "home_url",
                value: "https://gitlab.com/my-privacy-dns/matrix/matrix/");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1934L,
                column: "home_url",
                value: "https://gitlab.com/my-privacy-dns/matrix/matrix/");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2566L,
                columns: new[] { "email_address", "forum_url", "home_url", "issues_url", "onion_url", "policy_url", "submission_url" },
                values: new object[] { "incoming+my-privacy-dns-porn-records-2-dmptefj25u6tlslz82c3oolb9-issue@noreply.mypdns.org", null, "https://mypdns.org/my-privacy-dns/porn-records", "https://mypdns.org/my-privacy-dns/porn-records/-/issues", null, "https://mypdns.org/my-privacy-dns/porn-records/-/blob/master/README.md", "https://mypdns.org/my-privacy-dns/porn-records/-/issues" });
        }
    }
}
