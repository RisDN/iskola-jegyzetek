
interface TitleProps {
    text: string;
}

const Title = ({ text }: TitleProps) => {
    return (
        <h1 className="font-bold text-2xl">{text}</h1>
    );
};


export default Title;