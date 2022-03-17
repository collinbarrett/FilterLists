using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2844 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2566L, "https://matrix.to/#/#porn-records:anontier.nl", "Porn Records Blacklisting. Porn Records from My Privacy DNS is among the best maintained projects and one of them with the lowest FP's as all records are veryfied by a human before committed to the lists. We do also have a Browser add-on for simple committing new domains", "https://ko-fi.com/X8X37FUGU", "incoming+my-privacy-dns-porn-records-2-dmptefj25u6tlslz82c3oolb9-issue@noreply.mypdns.org", null, "https://mypdns.org/my-privacy-dns/porn-records", true, "https://mypdns.org/my-privacy-dns/porn-records/-/issues", 13L, "My Privacy DNS - Porn Records Blacklist", null, "https://mypdns.org/my-privacy-dns/porn-records/-/blob/master/README.md", "https://mypdns.org/my-privacy-dns/porn-records/-/issues" });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[,]
                {
                    { 168L, null, true, "spirillen", null, "https://mypdns.org/spirillen" },
                    { 169L, null, true, "Porn Records", null, "https://mypdns.org/porn-records" },
                    { 170L, null, true, "Razor (@RexAdev)", null, "https://mypdns.org/razor" },
                    { 171L, null, true, "Titom", null, "https://mypdns.org/Titomrock21" }
                });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[] { 2566L, 37L });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2566L, 168L },
                    { 2566L, 169L },
                    { 2566L, 170L },
                    { 2566L, 171L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2566L, 11L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[,]
                {
                    { 2566L, 2814L, (short)1, (short)1, "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2815L, (short)2, (short)1, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2816L, (short)3, (short)1, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2817L, (short)4, (short)1, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/wildcard.list" },
                    { 2566L, 2818L, (short)1, (short)2, "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2819L, (short)2, (short)2, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2820L, (short)3, (short)2, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2821L, (short)4, (short)2, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/tld.list" },
                    { 2566L, 2822L, (short)1, (short)3, "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2823L, (short)2, (short)3, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2824L, (short)3, (short)3, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2825L, (short)4, (short)3, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/domains.list" },
                    { 2566L, 2826L, (short)1, (short)4, "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2827L, (short)2, (short)4, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2828L, (short)3, (short)4, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2829L, (short)4, (short)4, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/hosts.list" },
                    { 2566L, 2830L, (short)1, (short)5, "https://mypdns.org/my-privacy-dns/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/snuff.list" },
                    { 2566L, 2831L, (short)2, (short)5, "https://raw.githubusercontent.com/mypdns/porn-records/master/submit_here/adult.mypdns.cloud/snuff.list" },
                    { 2566L, 2832L, (short)3, (short)5, "https://raw.githubusercontent.com/porn-records/porn-records/master/submit_here/adult.mypdns.cloud/snuff.list" },
                    { 2566L, 2833L, (short)4, (short)5, "https://gitlab.com/MypDNS/porn-records/-/raw/master/submit_here/adult.mypdns.cloud/snuff.list" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2566L, 37L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2566L, 168L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2566L, 169L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2566L, 170L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2566L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2566L, 11L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2566L, 2814L });

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
                keyValues: new object[] { 2566L, 2818L });

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
                keyValues: new object[] { 2566L, 2822L });

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
                keyValues: new object[] { 2566L, 2826L });

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
                keyValues: new object[] { 2566L, 2830L });

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

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2566L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 171L);
        }
    }
}
