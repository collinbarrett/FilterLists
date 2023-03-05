using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3448 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2152L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2152L, 36L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2316L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2316L, 36L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2152L, 54L },
                    { 2316L, 54L }
                });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2317L, 2464L },
                column: "url",
                value: "https://raw.githubusercontent.com/bongochong/CombinedPrivacyBlockLists/master/combined-final.cidr");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1523L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv4) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1524L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is an IP block list (DAT-format) suitable for use in torrent clients like Halite for Windows, or qBitTorrent and Transmission under any OS. The list is merged from BlueTack Web Attacks, Hijacks, and Bad Peers, then deduped and sorted. The list adheres to ipfilter.dat conventions, and will come in especially handy on public trackers.", "Combined Privacy Block Lists IP Filter (DAT-format, IPv4)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1525L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is an IP block list (P2P-format) suitable for use in torrent clients like qBitTorrent and Transmission under any OS. The list is merged from BlueTack Web Attacks, Hijacks, and Bad Peers, then deduped and sorted. The list adheres to ipfilter.dat conventions, and will come in especially handy on public trackers.", "Combined Privacy Block Lists IP Filter (P2P-format, IPv4)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2151L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2152L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv4 + IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2315L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv4, optimized for Windows users) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2316L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv4 + IPv6, optimized for Windows users) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, URL Haus and EasyList, along with a variety of supplementary sources for increased protection against telemetry, additions for mobile platforms, and emerging threat prevention. It is then merged, sorted and deduped. A notably enhanced experience with the world wide web awaits you.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2317L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a CIDR-format IP block list suitable for use with the IPSet utility, Linux-based routers, a variety of firewalls, older P2P clients and so on. Basically, it works with anything which accepts CIDR lists. It is compiled from the ad-blocking IP list provided by PGL Yoyo, a collection of smaller lists from BlockList.de, the FeodoTracker abuse list, high confidence Emerging Threats lists, along with DShield's Top Twenty, SpamHaus Drop + eDrop, and a conservative list of IPv4 bogons. It also incorporates a small list of IPs I've observed malicious activity from, via running public Shoutcast and Icecast servers for extended periods of time. It is likewise deduped + sorted (with overlapping ranges resolved).", "Combined Privacy Block Lists CIDR (CIDR, IPv4)" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2152L, 54L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2316L, 54L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2152L, 1L },
                    { 2152L, 36L },
                    { 2316L, 1L },
                    { 2316L, 36L }
                });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2317L, 2464L },
                column: "url",
                value: "https://raw.githubusercontent.com/bongochong/CombinedPrivacyBlockLists/master/NoFormatting/combined-flat.cidr");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1523L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv4) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, Energized and EasyList, along with some supplementary entries for increased protection against telemetry, and additions for mobile platforms. It is then merged, sorted and deduped. This list is compatible with all operating systems that make use of a hosts file (obviously this includes Windows, OS X, GNU/Linux and more). It works great with mobile VPN ad-blocking solutions too.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1524L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a DAT-format IP block list suitable for use in torrent clients like Halite for Windows. The list is merged from BlueTack levels 1 and 2, then deduped and sorted. This will come in especially handy on public trackers.", "Combined Privacy Block Lists IPs DAT-format" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1525L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a P2P-format IP block list suitable for use in torrent clients like qBitTorrent and Transmission under any OS. The list is merged from BlueTack levels 1 and 2, then deduped and sorted. This will also come in especially handy on public trackers.", "Combined Privacy Block Lists IPs P2P-format" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2151L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, Energized and EasyList, along with some supplementary entries for increased protection against telemetry, and additions for mobile platforms. It is then merged, sorted and deduped. This list is compatible with all operating systems that make use of a hosts file (obviously this includes Windows, OS X, GNU/Linux and more). It works great with mobile VPN ad-blocking solutions too.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2152L,
                column: "description",
                value: "This is a comprehensive hosts file (IPv4 + IPv6) which blocks known ad, exploit, malware, and tracking servers. It is pulled from MVPS, PGL Yoyo, Malware Domain List, Energized and EasyList, along with some supplementary entries for increased protection against telemetry, and additions for mobile platforms. It is then merged, sorted and deduped. This list is compatible with all operating systems that make use of a hosts file (obviously this includes Windows, OS X, GNU/Linux and more). It works great with mobile VPN ad-blocking solutions too.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2315L,
                column: "description",
                value: "This is a hosts file (IPv4) specifically tailored for Windows users, wherein the list is arranged to have seven hosts per line, thus saving space, and preventing the lag that some users experience when they have a large hosts file on that platform. It is culled from the same sources as the other Combined Privacy Block Lists hosts files.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2316L,
                column: "description",
                value: "This is a hosts file (IPv4 + IPv6) specifically tailored for Windows users, wherein the list is arranged to have seven hosts per line, thus saving space, and preventing the lag that some users experience when they have a large hosts file on that platform. It is culled from the same sources as the other Combined Privacy Block Lists hosts files.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2317L,
                columns: new[] { "description", "name" },
                values: new object[] { "This is a CIDR-format IP block list suitable for routers, older P2P clients and so on, which accept CIDR lists. It is compiled from the same sources as the other IP block lists from Combined Privacy Block Lists, and is likewise deduped + sorted.", "Combined Privacy Block Lists Optimized Windows HOSTS (CIDR)" });
        }
    }
}
