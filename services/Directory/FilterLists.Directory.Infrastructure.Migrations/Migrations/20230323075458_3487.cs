using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3487 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2602L, 113L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2602L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2602L, 2867L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2603L, 2868L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2604L, 2869L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2605L, 2870L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2606L, 2871L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2607L, 2873L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2608L, 2874L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2609L, 2875L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2610L, 2876L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2611L, 2878L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2612L, 2879L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2613L, 2880L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2614L, 2881L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2615L, 2882L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2616L, 2883L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2617L, 2884L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2618L, 2885L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2619L, 2886L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2602L);

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2519L, 17L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2607L, 2872L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AnnoyancesList-2ndDivision.txt" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2611L, 2877L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/DeviantARTQualityArtMagnifier.txt" });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2603L, 2867L, (short)1, "https://gitlab.com/magnolia1234/bypass-paywalls-clean-filters/-/raw/main/bpc-paywall-filter.txt" },
                    { 2604L, 2868L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/anti-gotoup-buttons/master/filter.txt" },
                    { 2605L, 2869L, (short)1, "https://lpt.lrv.lt/uploads/lpt/documents/files/institucijoms.txt" },
                    { 2606L, 2870L, (short)1, "https://lpt.lrv.lt/uploads/lpt/documents/files/neleg.txt" },
                    { 2607L, 2871L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AnnoyancesList-2ndDivision.txt" },
                    { 2608L, 2873L, (short)1, "https://raw.githubusercontent.com/MasterKia/PersianBlocker/main/PersianBlocker.txt" },
                    { 2609L, 2874L, (short)1, "https://raw.githubusercontent.com/MasterKia/PersianBlocker/main/PersianBlockerHosts.txt" },
                    { 2610L, 2875L, (short)1, "https://filters.adtidy.org/windows/filters/22.txt" },
                    { 2611L, 2876L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/DeviantARTQualityArtMagnifier.txt" },
                    { 2612L, 2878L, (short)1, "https://raw.githubusercontent.com/Leaf16591/AdAway-Default-Blocklist-AdGuard-Version/main/Host" },
                    { 2613L, 2879L, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/Inversion-CloudIPs/main/ips.txt" },
                    { 2614L, 2880L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/no-newsletter/master/filter.txt" },
                    { 2615L, 2881L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/3rdParty.txt" },
                    { 2616L, 2882L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/All.txt" },
                    { 2617L, 2883L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/googleyt-exception.txt" },
                    { 2618L, 2884L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/socialmedia-exception.txt" },
                    { 2619L, 2885L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Non-Essential-Frames-Blocker/main/filter.txt" }
                });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2519L,
                column: "license_id",
                value: 6L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2519L, 17L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2603L, 2867L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2604L, 2868L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2605L, 2869L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2606L, 2870L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2607L, 2871L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2608L, 2873L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2609L, 2874L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2610L, 2875L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2611L, 2876L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2612L, 2878L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2613L, 2879L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2614L, 2880L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2615L, 2881L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2616L, 2882L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2617L, 2883L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2618L, 2884L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2619L, 2885L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2607L, 2872L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AnnoyancesList-2ndDivision.txt" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2611L, 2877L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/DeviantARTQualityArtMagnifier.txt" });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2603L, 2868L, (short)1, "https://gitlab.com/magnolia1234/bypass-paywalls-clean-filters/-/raw/main/bpc-paywall-filter.txt" },
                    { 2604L, 2869L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/anti-gotoup-buttons/master/filter.txt" },
                    { 2605L, 2870L, (short)1, "https://lpt.lrv.lt/uploads/lpt/documents/files/institucijoms.txt" },
                    { 2606L, 2871L, (short)1, "https://lpt.lrv.lt/uploads/lpt/documents/files/neleg.txt" },
                    { 2607L, 2873L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AnnoyancesList-2ndDivision.txt" },
                    { 2608L, 2874L, (short)1, "https://raw.githubusercontent.com/MasterKia/PersianBlocker/main/PersianBlocker.txt" },
                    { 2609L, 2875L, (short)1, "https://raw.githubusercontent.com/MasterKia/PersianBlocker/main/PersianBlockerHosts.txt" },
                    { 2610L, 2876L, (short)1, "https://filters.adtidy.org/windows/filters/22.txt" },
                    { 2611L, 2878L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/DeviantARTQualityArtMagnifier.txt" },
                    { 2612L, 2879L, (short)1, "https://raw.githubusercontent.com/Leaf16591/AdAway-Default-Blocklist-AdGuard-Version/main/Host" },
                    { 2613L, 2880L, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/Inversion-CloudIPs/main/ips.txt" },
                    { 2614L, 2881L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/no-newsletter/master/filter.txt" },
                    { 2615L, 2882L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/3rdParty.txt" },
                    { 2616L, 2883L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/All.txt" },
                    { 2617L, 2884L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/googleyt-exception.txt" },
                    { 2618L, 2885L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/socialmedia-exception.txt" },
                    { 2619L, 2886L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Non-Essential-Frames-Blocker/main/filter.txt" }
                });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2519L,
                column: "license_id",
                value: 4L);

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2602L, null, "(JohnyP36:) My own updated version of EasyList Dutch. I made this filter because the EasyList Dutch filter isn't maintained often. And more important: EasyList doesn't allow anti-adblock rules.", "https://www.paypal.com/donate?hosted_button_id=8BBT5V55TGVXW", null, null, "https://github.com/JohnyP36/Personal-List", true, null, 4L, "EasyList Dutch (JohnyP36)", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[] { 2602L, 113L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2602L, 4L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2602L, 2867L, (short)1, "https://raw.githubusercontent.com/JohnyP36/Personal-List/main/Personal List (uBo).txt" });
        }
    }
}
