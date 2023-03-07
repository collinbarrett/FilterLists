using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3452 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1523L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, an updated fork of Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "CPBL Hosts (IPv4)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1524L,
                column: "name",
                value: "CPBL IP Filter (DAT-format, IPv4)");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1525L,
                column: "name",
                value: "CPBL IP Filter (P2P-format, IPv4)");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2151L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, an updated fork of Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "CPBL Hosts (IPv6)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2152L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4 + IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, an updated fork of Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "CPBL Hosts (IPv4 + IPv6)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2315L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4, optimized for Windows users) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, an updated fork of Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "CPBL Optimized Windows Hosts (IPv4)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2316L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4 + IPv6, optimized for Windows users) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, an updated fork of Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "CPBL Optimized Windows Hosts (IPv4 + IPv6)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2317L,
                column: "name",
                value: "CPBL CIDR (IPv4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1523L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "Combined Privacy Block Lists HOSTS (IPv4)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1524L,
                column: "name",
                value: "Combined Privacy Block Lists IP Filter (DAT-format, IPv4)");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1525L,
                column: "name",
                value: "Combined Privacy Block Lists IP Filter (P2P-format, IPv4)");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2151L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "Combined Privacy Block Lists HOSTS (IPv6)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2152L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4 + IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "Combined Privacy Block Lists HOSTS (IPv4 + IPv6)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2315L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4, optimized for Windows users) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "Combined Privacy Block Lists Optimized Windows HOSTS (IPv4)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2316L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a comprehensive hosts file (IPv4 + IPv6, optimized for Windows users) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.", "Combined Privacy Block Lists Optimized Windows HOSTS (IPv4 + IPv6)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2317L,
                column: "name",
                value: "Combined Privacy Block Lists CIDR (CIDR, IPv4)");
        }
    }
}
