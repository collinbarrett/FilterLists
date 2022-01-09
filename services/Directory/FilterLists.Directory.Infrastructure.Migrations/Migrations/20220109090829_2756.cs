using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2756 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1603L, 1628L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1603L, 1629L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1880L, 1952L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1880L, 1953L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2165L, 2290L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2165L, 2291L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2167L, 2296L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2167L, 2297L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2169L, 2302L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2169L, 2303L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2171L, 2308L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2171L, 2309L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2323L, 2473L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2323L, 2474L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2324L, 2476L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2324L, 2477L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2325L, 2479L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2325L, 2480L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2326L, 2482L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2326L, 2483L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2327L, 2485L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2327L, 2486L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2328L, 2488L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2328L, 2489L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[,]
                {
                    { 1603L, 1628L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/urlhaus-filter/master/urlhaus-filter-online.txt" },
                    { 1603L, 1629L, (short)3, (short)0, "https://glcdn.githack.com/curben/urlhaus-filter/raw/master/urlhaus-filter-online.txt" },
                    { 1880L, 1952L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/urlhaus-filter/master/urlhaus-filter-domains-online.txt" },
                    { 1880L, 1953L, (short)3, (short)0, "https://glcdn.githack.com/curben/urlhaus-filter/raw/master/urlhaus-filter-domains-online.txt" },
                    { 2165L, 2290L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/urlhaus-filter/master/urlhaus-filter-dnsmasq-online.conf" },
                    { 2165L, 2291L, (short)3, (short)0, "https://glcdn.githack.com/curben/urlhaus-filter/raw/master/urlhaus-filter-dnsmasq-online.conf" },
                    { 2167L, 2296L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/urlhaus-filter/master/urlhaus-filter-hosts-online.txt" },
                    { 2167L, 2297L, (short)3, (short)0, "https://glcdn.githack.com/curben/urlhaus-filter/raw/master/urlhaus-filter-hosts-online.txt" },
                    { 2169L, 2302L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/urlhaus-filter/master/urlhaus-filter-bind-online.conf" },
                    { 2169L, 2303L, (short)3, (short)0, "https://glcdn.githack.com/curben/urlhaus-filter/raw/master/urlhaus-filter-bind-online.conf" },
                    { 2171L, 2308L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/urlhaus-filter/master/urlhaus-filter-unbound-online.conf" },
                    { 2171L, 2309L, (short)3, (short)0, "https://glcdn.githack.com/curben/urlhaus-filter/raw/master/urlhaus-filter-unbound-online.conf" },
                    { 2323L, 2473L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/phishing-filter/master/dist/phishing-filter.txt" },
                    { 2323L, 2474L, (short)3, (short)0, "https://glcdn.githack.com/curben/phishing-filter/raw/master/dist/phishing-filter.txt" },
                    { 2324L, 2476L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/phishing-filter/master/phishing-filter-domains.txt" },
                    { 2324L, 2477L, (short)3, (short)0, "https://glcdn.githack.com/curben/phishing-filter/raw/master/dist/phishing-filter-domains.txt" },
                    { 2325L, 2479L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/phishing-filter/master/dist/phishing-filter-dnsmasq.conf" },
                    { 2325L, 2480L, (short)3, (short)0, "https://glcdn.githack.com/curben/phishing-filter/raw/master/dist/phishing-filter-dnsmasq.conf" },
                    { 2326L, 2482L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/phishing-filter/master/dist/phishing-filter-hosts.txt" },
                    { 2326L, 2483L, (short)3, (short)0, "https://glcdn.githack.com/curben/phishing-filter/raw/master/dist/phishing-filter-hosts.txt" },
                    { 2327L, 2485L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/phishing-filter/master/dist/phishing-filter-bind.conf" },
                    { 2327L, 2486L, (short)3, (short)0, "https://glcdn.githack.com/curben/phishing-filter/raw/master/dist/phishing-filter-bind.conf" },
                    { 2328L, 2488L, (short)2, (short)0, "https://cdn.statically.io/gl/curben/phishing-filter/master/dist/phishing-filter-unbound.conf" },
                    { 2328L, 2489L, (short)3, (short)0, "https://glcdn.githack.com/curben/phishing-filter/raw/master/dist/phishing-filter-unbound.conf" }
                });
        }
    }
}
