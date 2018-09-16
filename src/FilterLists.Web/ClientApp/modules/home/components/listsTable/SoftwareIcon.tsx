import * as React from "react";
import img1 from "../../../../imgs/software/01-uBlock-Origin.svg";
import img2 from "../../../../imgs/software/02-Adblock-Plus.svg";
import img3 from "../../../../imgs/software/03-AdGuard.png";
import img4 from "../../../../imgs/software/04-DNS66.png";
import img5 from "../../../../imgs/software/05-Nano-Adblocker.png";
import img6 from "../../../../imgs/software/06-AdBlock.png";
import img7 from "../../../../imgs/software/07-AdAway.png";
import img8 from "../../../../imgs/software/08-Personal-Blocklist.png";
import img10 from "../../../../imgs/software/10-Redirector.png";
import img13 from "../../../../imgs/software/13-MinerBlock.svg";
import img14 from "../../../../imgs/software/14-Pi-hole.png";
import img15 from "../../../../imgs/software/15-uBlock.svg";
import img16 from "../../../../imgs/software/16-Internet-Explorer-TPL.png";
import img18 from "../../../../imgs/software/18-FireHOL.png";

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
    13: { image: img13, imageTitle: "MinerBlock" },
    14: { image: img14, imageTitle: "Pi-hole" },
    15: { image: img15, imageTitle: "uBlock" },
    16: { image: img16, imageTitle: "Internet Explorer (TPL)" },
    18: { image: img18, imageTitle: "FireHOL" }
};