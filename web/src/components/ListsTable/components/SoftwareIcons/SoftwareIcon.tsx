import {
  img01,
  img02,
  img03,
  img04,
  img05,
  img06,
  img07,
  img08,
  img10,
  img11,
  img12,
  img13,
  img14,
  img15,
  img16,
  img17,
  img18,
  img19,
  img20,
  img21,
  img22,
  img23,
  img24,
  img25,
  img26,
  img27,
  img28,
  img29,
  img30,
  img31,
  img32,
  img33,
  img34,
  img35,
  img36,
  img37,
  img38,
  img39,
  img40,
  img41,
  img42,
  img43,
  img44,
  img45,
  img46,
  img47,
} from "./imgs";
import Image from "next/image";

interface Props {
  id: number;
}

export const SoftwareIcon = ({ id }: Props) => {
  const icon = icons.get(id);
  // TODO: get latest full size logos and let next Image optimize
  return icon ? <Image src={icon.image} height="20" alt={icon.title} /> : null;
};

interface Icon {
  image: any;
  title: string;
}

const icons = new Map<number, Icon>([
  [1, { image: img01, title: "uBlock Origin" }],
  [2, { image: img02, title: "Adblock Plus" }],
  [3, { image: img03, title: "AdGuard (free versions)" }],
  [4, { image: img04, title: "DNS66" }],
  [5, { image: img05, title: "Nano Adblocker" }],
  [6, { image: img06, title: "AdBlock" }],
  [7, { image: img07, title: "AdAway" }],
  [8, { image: img08, title: "Personal Blocklist" }],
  [10, { image: img10, title: "Redirector" }],
  [11, { image: img11, title: "Hosts File Editor" }],
  [12, { image: img12, title: "Gas Mask" }],
  [13, { image: img13, title: "MinerBlock" }],
  [14, { image: img14, title: "Pi-hole" }],
  [15, { image: img15, title: "uBlock" }],
  [16, { image: img16, title: "Internet Explorer (TPL)" }],
  [17, { image: img17, title: "Google Hit Hider by Domain" }],
  [18, { image: img18, title: "FireHOL" }],
  [19, { image: img19, title: "Samsung Knox" }],
  [20, { image: img20, title: "Little Snitch" }],
  [21, { image: img21, title: "Privoxy" }],
  [22, { image: img22, title: "Diversion" }],
  [23, { image: img23, title: "dnsmasq" }],
  [24, { image: img24, title: "Slimjet" }],
  [25, { image: img25, title: "uMatrix" }],
  [26, { image: img26, title: "Blokada" }],
  [27, { image: img27, title: "hostsmgr" }],
  [28, { image: img28, title: "personalDNSfilter" }],
  [29, { image: img29, title: "Unbound" }],
  [30, { image: img30, title: "BIND" }],
  [31, { image: img31, title: "AdGuard Home" }],
  [32, { image: img32, title: "AdNauseam" }],
  [33, { image: img33, title: "Legacy Unix derivatives" }],
  [34, { image: img34, title: "Windows command line" }],
  [35, { image: img35, title: "Shadowsocks" }],
  [36, { image: img36, title: "ShadowsocksR" }],
  [37, { image: img37, title: "Shadowrocket" }],
  [38, { image: img38, title: "DNSRedirector" }],
  [39, { image: img39, title: "pfBlockerNG" }],
  [40, { image: img40, title: "Opera's built-in adblocker" }],
  [41, { image: img41, title: "Surge" }],
  [42, { image: img42, title: "dnscrypt-proxy" }],
  [43, { image: img43, title: "SmartDNS" }],
  [44, { image: img44, title: "AdGuard for Windows/macOS" }],
  [45, { image: img45, title: "AdGuard for Android" }],
  [46, { image: img46, title: "Vivaldi's Privacy settings" }],
  [47, { image: img47, title: "Polish Cookie Consent" }],
]);