interface TextContentProps {
    title: string;
    text: string;
}

const TextContent = ({ title, text }: TextContentProps) => {
    return (
        <div className="p-6">
            <h1 className="font-bold text-2xl py-5">{title}</h1>
            <div className="" dangerouslySetInnerHTML={{ __html: text }} />
        </div>

    );
};

export default TextContent;