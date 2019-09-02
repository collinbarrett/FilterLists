import * as React from 'react';

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
    img37
} from './imgs';

interface Props {
    id: number;
};

export const SoftwareIcon = (props: Props) =>
    icons[props.id]
        ? <img
            src={icons[props.id].image}
            height="20"
            alt={icons[props.id].imageTitle}
            title={`View ${icons[props.id].imageTitle}'s homepage.`} />
        : null;

interface Icon {
    image: any;
    imageTitle: string;
};

const icons: { [id: number]: Icon; } = {
    1: { image: img01, imageTitle: "uBlock Origin" },
    2: { image: img02, imageTitle: "Adblock Plus" },
    3: { image: img03, imageTitle: "AdGuard" },
    4: { image: img04, imageTitle: "DNS66" },
    5: { image: img05, imageTitle: "Nano Adblocker" },
    6: { image: img06, imageTitle: "AdBlock" },
    7: { image: img07, imageTitle: "AdAway" },
    8: { image: img08, imageTitle: "Personal Blocklist" },
    10: { image: img10, imageTitle: "Redirector" },
    11: { image: img11, imageTitle: "Hosts File Editor" },
    12: { image: img12, imageTitle: "Gas Mask" },
    13: { image: img13, imageTitle: "MinerBlock" },
    14: { image: img14, imageTitle: "Pi-hole" },
    15: { image: img15, imageTitle: "uBlock" },
    16: { image: img16, imageTitle: "Internet Explorer (TPL)" },
    17: { image: img17, imageTitle: "Google Hit Hider by Domain" },
    18: { image: img18, imageTitle: "FireHOL" },
    19: { image: img19, imageTitle: "Samsung Knox" },
    20: { image: img20, imageTitle: "Little Snitch" },
    21: { image: img21, imageTitle: "Privoxy" },
    22: { image: img22, imageTitle: "Diversion" },
    23: { image: img23, imageTitle: "dnsmasq" },
    24: { image: img24, imageTitle: "Slimjet" },
    25: { image: img25, imageTitle: "uMatrix" },
    26: { image: img26, imageTitle: "Blokada" },
    27: { image: img27, imageTitle: "hostsmgr" },
    28: { image: img28, imageTitle: "personalDNSfilter" },
    29: { image: img29, imageTitle: "Unbound" },
    30: { image: img30, imageTitle: "BIND" },
    31: { image: img31, imageTitle: "AdGuard Home" },
    32: { image: img32, imageTitle: "AdNauseam" },
    33: { image: img33, imageTitle: "Legacy Unix derivatives" },
    34: { image: img34, imageTitle: "Windows command line" },
    35: { image: img35, imageTitle: "Shadowsocks" },
    36: { image: img36, imageTitle: "ShadowsocksR" },
    37: { image: img37, imageTitle: "Shadowrocket" }
};