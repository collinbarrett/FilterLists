import { useEffect, useState } from 'react';

export const useApiData = <T extends {}>(url: string) => {
    const [data, setData] = useState<T>();
    useEffect(() => {
        const fetchData = async () => (await fetch(url)).json().then(r => setData(r));
        fetchData();
    }, [url]);
    return data;
};