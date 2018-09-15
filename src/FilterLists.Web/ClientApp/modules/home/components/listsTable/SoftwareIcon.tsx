import * as React from "react";
import img1 from "../../../../imgs/software/1-uBlock-Origin.svg";
import img2 from "../../../../imgs/software/2-Adblock-Plus.svg";
import img3 from "../../../../imgs/software/3-AdGuard.png";
import img4 from "../../../../imgs/software/4-DNS66.png";
import img5 from "../../../../imgs/software/5-Nano-Adblocker.png";
import img6 from "../../../../imgs/software/6-AdBlock.png";
import img7 from "../../../../imgs/software/7-AdAway.png";
import img8 from "../../../../imgs/software/8-Personal-Blocklist.png";

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
    8: { image: img8, imageTitle: "Personal Blocklist" }
};