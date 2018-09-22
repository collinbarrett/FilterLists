import * as React from "react";
import {
    img1,
    img2,
    img3,
    img4,
    img5,
    img6,
    img7,
    img8,
    img10,
    img12,
    img13,
    img14,
    img15,
    img16,
    img18,
    img19,
    img20,
    img21
} from "./imgs";

interface IProps {
    id: number;
}

export const SoftwareIcon = (props: IProps) => {
    return icons[props.id]
               ? <img src={icons[props.id].image}
                      width="20"
                      alt={icons[props.id].imageTitle}
                      title={icons[props.id].imageTitle}/>
               : null;
};

interface IIcon {
    image: any;
    imageTitle: string;
}

const icons: { [id: number]: IIcon; } = {
    1: { image: img1, imageTitle: "uBlock Origin" },
    2: { image: img2, imageTitle: "Adblock Plus" },
    3: { image: img3, imageTitle: "AdGuard" },
    4: { image: img4, imageTitle: "DNS66" },
    5: { image: img5, imageTitle: "Nano Adblocker" },
    6: { image: img6, imageTitle: "AdBlock" },
    7: { image: img7, imageTitle: "AdAway" },
    8: { image: img8, imageTitle: "Personal Blocklist" },
    10: { image: img10, imageTitle: "Redirector" },
    12: { image: img12, imageTitle: "Gas Mask" },
    13: { image: img13, imageTitle: "MinerBlock" },
    14: { image: img14, imageTitle: "Pi-hole" },
    15: { image: img15, imageTitle: "uBlock" },
    16: { image: img16, imageTitle: "Internet Explorer (TPL)" },
    18: { image: img18, imageTitle: "FireHOL" },
    19: { image: img19, imageTitle: "Samsung Knox" },
    20: { image: img20, imageTitle: "Little Snitch" },
    21: { image: img21, imageTitle: "Privoxy" }
};
